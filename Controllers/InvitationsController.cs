using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Api.Common;
using WeddingPlanner.Api.DTOs.Invitations;
using WeddingPlanner.Api.Interfaces;

namespace WeddingPlanner.Api.Controllers;

[ApiController]
[Authorize]
public class InvitationsController : ControllerBase
{
    private readonly IInvitationService _invitationService;

    public InvitationsController(IInvitationService invitationService)
    {
        _invitationService = invitationService;
    }

    [HttpPost("api/wedding-spaces/{weddingSpaceId:guid}/invitations")]
    public async Task<ActionResult<InvitationResponse>> Create(Guid weddingSpaceId)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _invitationService.CreateAsync(userId, weddingSpaceId);
        return Ok(response);
    }

    [HttpPost("api/invitations/join")]
    public async Task<ActionResult<JoinInvitationResponse>> Join(JoinInvitationRequest request)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _invitationService.JoinAsync(userId, request);
        return Ok(response);
    }
}
