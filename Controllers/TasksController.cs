using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Api.Common;
using WeddingPlanner.Api.DTOs.Tasks;
using WeddingPlanner.Api.Interfaces;

namespace WeddingPlanner.Api.Controllers;

[ApiController]
[Authorize]
public class TasksController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TasksController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet("api/categories/{categoryId:guid}/tasks")]
    public async Task<ActionResult<List<TaskResponse>>> GetForCategory(Guid categoryId)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _taskService.GetForCategoryAsync(userId, categoryId);
        return Ok(response);
    }

    [HttpPost("api/categories/{categoryId:guid}/tasks")]
    public async Task<ActionResult<TaskResponse>> Create(Guid categoryId, CreateTaskRequest request)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _taskService.CreateAsync(userId, categoryId, request);
        return Ok(response);
    }

    [HttpGet("api/tasks/{id:guid}")]
    public async Task<ActionResult<TaskResponse>> GetById(Guid id)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _taskService.GetByIdAsync(userId, id);
        return Ok(response);
    }

    [HttpPut("api/tasks/{id:guid}")]
    public async Task<ActionResult<TaskResponse>> Update(Guid id, UpdateTaskRequest request)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _taskService.UpdateAsync(userId, id, request);
        return Ok(response);
    }

    [HttpDelete("api/tasks/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var userId = CurrentUser.GetUserId(User);
        await _taskService.DeleteAsync(userId, id);
        return NoContent();
    }

    [HttpPatch("api/tasks/{id:guid}/status")]
    public async Task<ActionResult<TaskResponse>> SetStatus(Guid id, SetTaskStatusRequest request)
    {
        var userId = CurrentUser.GetUserId(User);
        var response = await _taskService.SetStatusAsync(userId, id, request.Status);
        return Ok(response);
    }
}
