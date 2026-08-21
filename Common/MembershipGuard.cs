using System.Net;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Api.Data;

namespace WeddingPlanner.Api.Common;

/// <summary>
/// Bölüm 4: Bir hazırlık alanındaki tüm kullanıcılar aynı yetkilere sahiptir.
/// Bu sınıf sadece kullanıcının o WeddingSpace'e üye olup olmadığını doğrular.
/// </summary>
public class MembershipGuard
{
    private readonly ApplicationDbContext _db;

    public MembershipGuard(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task EnsureMemberAsync(Guid userId, Guid weddingSpaceId)
    {
        var isMember = await _db.CoupleMembers
            .AnyAsync(m => m.UserId == userId && m.WeddingSpaceId == weddingSpaceId);

        if (!isMember)
        {
            throw new AppException("Bu hazırlık alanına erişim yetkiniz yok", HttpStatusCode.Forbidden);
        }
    }
}
