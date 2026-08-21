namespace WeddingPlanner.Api.Entities;

public class Category
{
    public Guid Id { get; set; }

    public Guid WeddingSpaceId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int Order { get; set; }

    public DateTime CreatedAt { get; set; }

    public WeddingSpace? WeddingSpace { get; set; }

    public List<WeddingTask> Tasks { get; set; } = new();
}
