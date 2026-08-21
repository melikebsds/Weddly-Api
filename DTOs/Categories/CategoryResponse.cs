namespace WeddingPlanner.Api.DTOs.Categories;

public class CategoryResponse
{
    public Guid Id { get; set; }

    public Guid WeddingSpaceId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int Order { get; set; }

    public DateTime CreatedAt { get; set; }

    public int TotalTaskCount { get; set; }

    public int CompletedTaskCount { get; set; }
}
