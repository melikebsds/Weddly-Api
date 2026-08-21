using System.Net;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Api.Common;
using WeddingPlanner.Api.Data;
using WeddingPlanner.Api.DTOs.Tasks;
using WeddingPlanner.Api.Entities;
using WeddingPlanner.Api.Interfaces;

namespace WeddingPlanner.Api.Services;

public class TaskService : ITaskService
{
    private readonly ApplicationDbContext _db;
    private readonly MembershipGuard _membershipGuard;

    public TaskService(ApplicationDbContext db, MembershipGuard membershipGuard)
    {
        _db = db;
        _membershipGuard = membershipGuard;
    }

    public async Task<List<TaskResponse>> GetForCategoryAsync(Guid userId, Guid categoryId)
    {
        var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == categoryId)
            ?? throw new AppException("Kategori bulunamadı", HttpStatusCode.NotFound);

        await _membershipGuard.EnsureMemberAsync(userId, category.WeddingSpaceId);

        var tasks = await _db.WeddingTasks
            .Where(t => t.CategoryId == categoryId)
            .OrderBy(t => t.CreatedAt)
            .ToListAsync();

        return tasks.Select(ToResponse).ToList();
    }

    public async Task<TaskResponse> CreateAsync(Guid userId, Guid categoryId, CreateTaskRequest request)
    {
        var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == categoryId)
            ?? throw new AppException("Kategori bulunamadı", HttpStatusCode.NotFound);

        await _membershipGuard.EnsureMemberAsync(userId, category.WeddingSpaceId);

        var now = DateTime.UtcNow;
        var task = new WeddingTask
        {
            Id = Guid.NewGuid(),
            WeddingSpaceId = category.WeddingSpaceId,
            CategoryId = categoryId,
            Title = request.Title.Trim(),
            Description = request.Description,
            EstimatedPrice = request.EstimatedPrice,
            ActualPrice = request.ActualPrice,
            AssignedUserId = request.AssignedUserId,
            IsCompleted = request.IsCompleted,
            CompletedAt = request.IsCompleted ? now : null,
            CreatedAt = now,
        };

        _db.WeddingTasks.Add(task);
        await _db.SaveChangesAsync();

        return ToResponse(task);
    }

    public async Task<TaskResponse> GetByIdAsync(Guid userId, Guid taskId)
    {
        var task = await FindTaskOrThrow(taskId);
        await _membershipGuard.EnsureMemberAsync(userId, task.WeddingSpaceId);
        return ToResponse(task);
    }

    public async Task<TaskResponse> UpdateAsync(Guid userId, Guid taskId, UpdateTaskRequest request)
    {
        var task = await FindTaskOrThrow(taskId);
        await _membershipGuard.EnsureMemberAsync(userId, task.WeddingSpaceId);

        var now = DateTime.UtcNow;

        task.Title = request.Title.Trim();
        task.Description = request.Description;
        task.EstimatedPrice = request.EstimatedPrice;
        task.ActualPrice = request.ActualPrice;
        task.AssignedUserId = request.AssignedUserId;

        if (task.IsCompleted != request.IsCompleted)
        {
            task.CompletedAt = request.IsCompleted ? now : null;
        }
        task.IsCompleted = request.IsCompleted;
        task.UpdatedAt = now;

        await _db.SaveChangesAsync();

        return ToResponse(task);
    }

    public async Task DeleteAsync(Guid userId, Guid taskId)
    {
        var task = await FindTaskOrThrow(taskId);
        await _membershipGuard.EnsureMemberAsync(userId, task.WeddingSpaceId);

        _db.WeddingTasks.Remove(task);
        await _db.SaveChangesAsync();
    }

    public async Task<TaskResponse> SetCompletedAsync(Guid userId, Guid taskId, bool isCompleted)
    {
        var task = await FindTaskOrThrow(taskId);
        await _membershipGuard.EnsureMemberAsync(userId, task.WeddingSpaceId);

        var now = DateTime.UtcNow;

        if (task.IsCompleted != isCompleted)
        {
            task.CompletedAt = isCompleted ? now : null;
        }
        task.IsCompleted = isCompleted;
        task.UpdatedAt = now;

        await _db.SaveChangesAsync();

        return ToResponse(task);
    }

    private async Task<Entities.WeddingTask> FindTaskOrThrow(Guid taskId)
    {
        return await _db.WeddingTasks.FirstOrDefaultAsync(t => t.Id == taskId)
            ?? throw new AppException("Görev bulunamadı", HttpStatusCode.NotFound);
    }

    private static TaskResponse ToResponse(Entities.WeddingTask task) => new()
    {
        Id = task.Id,
        WeddingSpaceId = task.WeddingSpaceId,
        CategoryId = task.CategoryId,
        Title = task.Title,
        Description = task.Description,
        EstimatedPrice = task.EstimatedPrice,
        ActualPrice = task.ActualPrice,
        AssignedUserId = task.AssignedUserId,
        IsCompleted = task.IsCompleted,
        CompletedAt = task.CompletedAt,
        CreatedAt = task.CreatedAt,
        UpdatedAt = task.UpdatedAt,
    };
}
