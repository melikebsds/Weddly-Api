using WeddingPlanner.Api.DTOs.Categories;

namespace WeddingPlanner.Api.Interfaces;

public interface ICategoryService
{
    Task<List<CategoryResponse>> GetForSpaceAsync(Guid userId, Guid weddingSpaceId);

    Task<CategoryResponse> CreateAsync(Guid userId, Guid weddingSpaceId, CreateCategoryRequest request);

    Task<CategoryResponse> UpdateAsync(Guid userId, Guid categoryId, UpdateCategoryRequest request);

    Task DeleteAsync(Guid userId, Guid categoryId);
}
