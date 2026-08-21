using WeddingPlanner.Api.DTOs.Invitations;

namespace WeddingPlanner.Api.Interfaces;

public interface IInvitationService
{
    Task<InvitationResponse> CreateAsync(Guid userId, Guid weddingSpaceId);

    Task<JoinInvitationResponse> JoinAsync(Guid userId, JoinInvitationRequest request);
}
