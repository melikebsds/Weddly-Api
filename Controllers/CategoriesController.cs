using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Api.Common;
using WeddingPlanner.Api.DTOs.Categories;
using WeddingPlanner.Api.Interfaces;

namespace WeddingPlanner.Api.Controllers;

[ApiController]
[Authorize]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("api/wedding-spaces/{weddingSpaceId:guid}/categories")]
    public async Task<ActionResult<List<CategoryResponse>>> GetForSpace(Guid weddingSpaceId)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _categoryService.GetForSpaceAsync(userId, weddingSpaceId);
        return Ok(response);
    }

    [HttpPost("api/wedding-spaces/{weddingSpaceId:guid}/categories")]
    public async Task<ActionResult<CategoryResponse>> Create(Guid weddingSpaceId, CreateCategoryRequest request)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _categoryService.CreateAsync(userId, weddingSpaceId, request);
        return Ok(response);
    }

    [HttpPut("api/categories/{id:guid}")]
    public async Task<ActionResult<CategoryResponse>> Update(Guid id, UpdateCategoryRequest request)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _categoryService.UpdateAsync(userId, id, request);
        return Ok(response);
    }

    [HttpDelete("api/categories/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var userId = CurrentUser.GetUserId(User);
        await _categoryService.DeleteAsync(userId, id);
        return NoContent();
    }
}
