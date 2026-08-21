namespace WeddingPlanner.Api.Entities;

public class Invitation
{
    public Guid Id { get; set; }

    public Guid WeddingSpaceId { get; set; }

    public string InvitationCode { get; set; } = string.Empty;

    public Guid CreatedByUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public Guid? UsedByUserId { get; set; }

    public DateTime? UsedAt { get; set; }

    public bool IsUsed { get; set; }

    public WeddingSpace? WeddingSpace { get; set; }
}
