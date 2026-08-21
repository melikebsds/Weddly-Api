using System.Net;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Api.Common;
using WeddingPlanner.Api.Data;
using WeddingPlanner.Api.DTOs.WeddingSpaces;
using WeddingPlanner.Api.Entities;
using WeddingPlanner.Api.Interfaces;

namespace WeddingPlanner.Api.Services;

public class WeddingSpaceService : IWeddingSpaceService
{
    private readonly ApplicationDbContext _db;
    private readonly MembershipGuard _membershipGuard;

    public WeddingSpaceService(ApplicationDbContext db, MembershipGuard membershipGuard)
    {
        _db = db;
        _membershipGuard = membershipGuard;
    }

    public async Task<WeddingSpaceResponse> CreateAsync(Guid userId, CreateWeddingSpaceRequest request)
    {
        var now = DateTime.UtcNow;

        var space = new WeddingSpace
        {
            Id = Guid.NewGuid(),
            Name = request.Name.Trim(),
            WeddingDate = request.WeddingDate,
            CreatedAt = now,
            CreatedByUserId = userId,
        };

        _db.WeddingSpaces.Add(space);

        _db.CoupleMembers.Add(new CoupleMember
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            WeddingSpaceId = space.Id,
            JoinedAt = now,
        });

        var categoriesByName = new Dictionary<string, Category>();
        foreach (var (name, order) in DefaultWeddingData.Categories)
        {
            var category = new Category
            {
                Id = Guid.NewGuid(),
                WeddingSpaceId = space.Id,
                Name = name,
                Order = order,
                CreatedAt = now,
            };
            categoriesByName[name] = category;
            _db.Categories.Add(category);
        }

        foreach (var (categoryName, title, estimatedPrice) in DefaultWeddingData.SampleTasks)
        {
            var category = categoriesByName[categoryName];
            _db.WeddingTasks.Add(new WeddingTask
            {
                Id = Guid.NewGuid(),
                WeddingSpaceId = space.Id,
                CategoryId = category.Id,
                Title = title,
                EstimatedPrice = estimatedPrice,
                CreatedAt = now,
            });
        }

        await _db.SaveChangesAsync();

        return ToResponse(space);
    }

    public async Task<List<WeddingSpaceResponse>> GetAllForUserAsync(Guid userId)
    {
        var spaces = await _db.CoupleMembers
            .Where(m => m.UserId == userId)
            .Include(m => m.WeddingSpace)
            .Select(m => m.WeddingSpace!)
            .ToListAsync();

        return spaces.Select(ToResponse).ToList();
    }

    public async Task<WeddingSpaceResponse> GetByIdAsync(Guid userId, Guid weddingSpaceId)
    {
        await _membershipGuard.EnsureMemberAsync(userId, weddingSpaceId);

        var space = await _db.WeddingSpaces.FindAsync(weddingSpaceId)
            ?? throw new AppException("Hazırlık alanı bulunamadı", HttpStatusCode.NotFound);

        return ToResponse(space);
    }

    public async Task<WeddingSpaceResponse> UpdateAsync(Guid userId, Guid weddingSpaceId, UpdateWeddingSpaceRequest request)
    {
        await _membershipGuard.EnsureMemberAsync(userId, weddingSpaceId);

        var space = await _db.WeddingSpaces.FindAsync(weddingSpaceId)
            ?? throw new AppException("Hazırlık alanı bulunamadı", HttpStatusCode.NotFound);

        space.Name = request.Name.Trim();
        space.WeddingDate = request.WeddingDate;

        await _db.SaveChangesAsync();

        return ToResponse(space);
    }

    private static WeddingSpaceResponse ToResponse(WeddingSpace space) => new()
    {
        Id = space.Id,
        Name = space.Name,
        WeddingDate = space.WeddingDate,
        CreatedAt = space.CreatedAt,
        CreatedByUserId = space.CreatedByUserId,
    };
}
