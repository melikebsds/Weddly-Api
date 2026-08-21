using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Api.Common;
using WeddingPlanner.Api.DTOs.WeddingSpaces;
using WeddingPlanner.Api.Interfaces;

namespace WeddingPlanner.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/wedding-spaces")]
public class WeddingSpacesController : ControllerBase
{
    private readonly IWeddingSpaceService _weddingSpaceService;

    public WeddingSpacesController(IWeddingSpaceService weddingSpaceService)
    {
        _weddingSpaceService = weddingSpaceService;
    }

    [HttpPost]
    public async Task<ActionResult<WeddingSpaceResponse>> Create(CreateWeddingSpaceRequest request)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _weddingSpaceService.CreateAsync(userId, request);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<List<WeddingSpaceResponse>>> GetAll()
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _weddingSpaceService.GetAllForUserAsync(userId);
        return Ok(response);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<WeddingSpaceResponse>> GetById(Guid id)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _weddingSpaceService.GetByIdAsync(userId, id);
        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult<WeddingSpaceResponse>> Update(Guid id, UpdateWeddingSpaceRequest request)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _weddingSpaceService.UpdateAsync(userId, id, request);
        return Ok(response);
    }
}
