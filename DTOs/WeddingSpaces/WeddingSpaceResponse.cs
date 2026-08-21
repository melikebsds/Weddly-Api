namespace WeddingPlanner.Api.DTOs.WeddingSpaces;

public class WeddingSpaceResponse
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public DateTime? WeddingDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid CreatedByUserId { get; set; }
}
