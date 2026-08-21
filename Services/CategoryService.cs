using System.Net;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Api.Common;
using WeddingPlanner.Api.Data;
using WeddingPlanner.Api.DTOs.Categories;
using WeddingPlanner.Api.Entities;
using WeddingPlanner.Api.Interfaces;

namespace WeddingPlanner.Api.Services;

public class CategoryService : ICategoryService
{
    private readonly ApplicationDbContext _db;
    private readonly MembershipGuard _membershipGuard;

    public CategoryService(ApplicationDbContext db, MembershipGuard membershipGuard)
    {
        _db = db;
        _membershipGuard = membershipGuard;
    }

    public async Task<List<CategoryResponse>> GetForSpaceAsync(Guid userId, Guid weddingSpaceId)
    {
        await _membershipGuard.EnsureMemberAsync(userId, weddingSpaceId);

        var categories = await _db.Categories
            .Where(c => c.WeddingSpaceId == weddingSpaceId)
            .OrderBy(c => c.Order)
            .Include(c => c.Tasks)
            .ToListAsync();

        return categories.Select(ToResponse).ToList();
    }

    public async Task<CategoryResponse> CreateAsync(Guid userId, Guid weddingSpaceId, CreateCategoryRequest request)
    {
        await _membershipGuard.EnsureMemberAsync(userId, weddingSpaceId);

        var category = new Category
        {
            Id = Guid.NewGuid(),
            WeddingSpaceId = weddingSpaceId,
            Name = request.Name.Trim(),
            Description = request.Description,
            Order = request.Order,
            CreatedAt = DateTime.UtcNow,
        };

        _db.Categories.Add(category);
        await _db.SaveChangesAsync();

        return ToResponse(category);
    }

    public async Task<CategoryResponse> UpdateAsync(Guid userId, Guid categoryId, UpdateCategoryRequest request)
    {
        var category = await _db.Categories.Include(c => c.Tasks).FirstOrDefaultAsync(c => c.Id == categoryId)
            ?? throw new AppException("Kategori bulunamadı", HttpStatusCode.NotFound);

        await _membershipGuard.EnsureMemberAsync(userId, category.WeddingSpaceId);

        category.Name = request.Name.Trim();
        category.Description = request.Description;
        category.Order = request.Order;

        await _db.SaveChangesAsync();

        return ToResponse(category);
    }

    public async Task DeleteAsync(Guid userId, Guid categoryId)
    {
        var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == categoryId)
            ?? throw new AppException("Kategori bulunamadı", HttpStatusCode.NotFound);

        await _membershipGuard.EnsureMemberAsync(userId, category.WeddingSpaceId);

        _db.Categories.Remove(category);
        await _db.SaveChangesAsync();
    }

    private static CategoryResponse ToResponse(Category category) => new()
    {
        Id = category.Id,
        WeddingSpaceId = category.WeddingSpaceId,
        Name = category.Name,
        Description = category.Description,
        Order = category.Order,
        CreatedAt = category.CreatedAt,
        // İhtiyaç Yok işaretlenen görevler hem toplamdan hem tamamlanandan tamamen hariç tutulur.
        TotalTaskCount = category.Tasks.Count(t => t.Status != WeddingTaskStatus.NotNeeded),
        CompletedTaskCount = category.Tasks.Count(t => t.Status == WeddingTaskStatus.Bought),
    };
}
