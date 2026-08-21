using WeddingPlanner.Api.DTOs.WeddingSpaces;

namespace WeddingPlanner.Api.Interfaces;

public interface IWeddingSpaceService
{
    Task<WeddingSpaceResponse> CreateAsync(Guid userId, CreateWeddingSpaceRequest request);

    Task<List<WeddingSpaceResponse>> GetAllForUserAsync(Guid userId);

    Task<WeddingSpaceResponse> GetByIdAsync(Guid userId, Guid weddingSpaceId);

    Task<WeddingSpaceResponse> UpdateAsync(Guid userId, Guid weddingSpaceId, UpdateWeddingSpaceRequest request);
}
