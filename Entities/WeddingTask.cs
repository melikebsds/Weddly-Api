namespace WeddingPlanner.Api.Entities;

public class WeddingTask
{
    public Guid Id { get; set; }

    public Guid WeddingSpaceId { get; set; }

    public Guid CategoryId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string? SubCategory { get; set; }

    public string? Description { get; set; }

    public decimal? EstimatedPrice { get; set; }

    public decimal? ActualPrice { get; set; }

    public Guid? AssignedUserId { get; set; }

    public WeddingTaskStatus Status { get; set; } = WeddingTaskStatus.ToBuy;

    public DateTime? CompletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Category? Category { get; set; }
}
