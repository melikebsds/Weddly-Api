using System.Net;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Api.Common;
using WeddingPlanner.Api.Data;
using WeddingPlanner.Api.DTOs.Invitations;
using WeddingPlanner.Api.Entities;
using WeddingPlanner.Api.Interfaces;

namespace WeddingPlanner.Api.Services;

public class InvitationService : IInvitationService
{
    private const string CodeAlphabet = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";

    private readonly ApplicationDbContext _db;
    private readonly MembershipGuard _membershipGuard;

    public InvitationService(ApplicationDbContext db, MembershipGuard membershipGuard)
    {
        _db = db;
        _membershipGuard = membershipGuard;
    }

    public async Task<InvitationResponse> CreateAsync(Guid userId, Guid weddingSpaceId)
    {
        await _membershipGuard.EnsureMemberAsync(userId, weddingSpaceId);

        var code = await GenerateUniqueCodeAsync();
        var now = DateTime.UtcNow;

        var invitation = new Invitation
        {
            Id = Guid.NewGuid(),
            WeddingSpaceId = weddingSpaceId,
            InvitationCode = code,
            CreatedByUserId = userId,
            CreatedAt = now,
            ExpiresAt = now.AddDays(7),
            IsUsed = false,
        };

        _db.Invitations.Add(invitation);
        await _db.SaveChangesAsync();

        return new InvitationResponse
        {
            Id = invitation.Id,
            InvitationCode = invitation.InvitationCode,
            CreatedAt = invitation.CreatedAt,
            ExpiresAt = invitation.ExpiresAt,
            IsUsed = invitation.IsUsed,
        };
    }

    public async Task<JoinInvitationResponse> JoinAsync(Guid userId, JoinInvitationRequest request)
    {
        var code = request.InvitationCode.Trim().ToUpperInvariant();

        var invitation = await _db.Invitations
            .Include(i => i.WeddingSpace)
            .FirstOrDefaultAsync(i => i.InvitationCode == code)
            ?? throw new AppException("Geçersiz davet kodu", HttpStatusCode.NotFound);

        if (invitation.IsUsed)
        {
            throw new AppException("Davet kodu daha önce kullanılmış", HttpStatusCode.Conflict);
        }

        if (invitation.ExpiresAt != null && invitation.ExpiresAt < DateTime.UtcNow)
        {
            throw new AppException("Davet kodunun süresi dolmuş", HttpStatusCode.Gone);
        }

        var alreadyMember = await _db.CoupleMembers
            .AnyAsync(m => m.UserId == userId && m.WeddingSpaceId == invitation.WeddingSpaceId);

        if (!alreadyMember)
        {
            _db.CoupleMembers.Add(new CoupleMember
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                WeddingSpaceId = invitation.WeddingSpaceId,
                JoinedAt = DateTime.UtcNow,
            });
        }

        invitation.IsUsed = true;
        invitation.UsedByUserId = userId;
        invitation.UsedAt = DateTime.UtcNow;

        await _db.SaveChangesAsync();

        return new JoinInvitationResponse
        {
            WeddingSpaceId = invitation.WeddingSpaceId,
            WeddingSpaceName = invitation.WeddingSpace!.Name,
        };
    }

    private async Task<string> GenerateUniqueCodeAsync()
    {
        var year = DateTime.UtcNow.Year;

        for (var attempt = 0; attempt < 10; attempt++)
        {
            var suffix = RandomNumberGenerator.GetString(CodeAlphabet, 4);
            var code = $"LOVE-{year}-{suffix}";

            var exists = await _db.Invitations.AnyAsync(i => i.InvitationCode == code);
            if (!exists)
            {
                return code;
            }
        }

        throw new AppException("Davet kodu üretilemedi, lütfen tekrar deneyin", HttpStatusCode.InternalServerError);
    }
}
