namespace WeddingPlanner.Api.DTOs.Tasks;

public class TaskResponse
{
    public Guid Id { get; set; }

    public Guid WeddingSpaceId { get; set; }

    public Guid CategoryId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal? EstimatedPrice { get; set; }

    public decimal? ActualPrice { get; set; }

    public Guid? AssignedUserId { get; set; }

    public bool IsCompleted { get; set; }

    public DateTime? CompletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
