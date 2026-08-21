namespace WeddingPlanner.Api.Entities;

public class WeddingSpace
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public DateTime? WeddingDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid CreatedByUserId { get; set; }

    public List<CoupleMember> Members { get; set; } = new();

    public List<Category> Categories { get; set; } = new();

    public List<Invitation> Invitations { get; set; } = new();
}
