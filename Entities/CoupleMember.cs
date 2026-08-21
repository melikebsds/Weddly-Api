namespace WeddingPlanner.Api.Entities;

public class CoupleMember
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid WeddingSpaceId { get; set; }

    public DateTime JoinedAt { get; set; }

    public User? User { get; set; }

    public WeddingSpace? WeddingSpace { get; set; }
}
