using WeddingPlanner.Api.DTOs.Tasks;
using WeddingPlanner.Api.Entities;

namespace WeddingPlanner.Api.Interfaces;

public interface ITaskService
{
    Task<List<TaskResponse>> GetForCategoryAsync(Guid userId, Guid categoryId);

    Task<TaskResponse> CreateAsync(Guid userId, Guid categoryId, CreateTaskRequest request);

    Task<TaskResponse> GetByIdAsync(Guid userId, Guid taskId);

    Task<TaskResponse> UpdateAsync(Guid userId, Guid taskId, UpdateTaskRequest request);

    Task DeleteAsync(Guid userId, Guid taskId);

    Task<TaskResponse> SetStatusAsync(Guid userId, Guid taskId, WeddingTaskStatus status);
}
