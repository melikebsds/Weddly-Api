using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Api.DTOs.Invitations;

public class JoinInvitationRequest
{
    [Required(ErrorMessage = "Kod boş olamaz")]
    public string InvitationCode { get; set; } = string.Empty;
}

public class InvitationResponse
{
    public Guid Id { get; set; }

    public string InvitationCode { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public bool IsUsed { get; set; }
}

public class JoinInvitationResponse
{
    public Guid WeddingSpaceId { get; set; }

    public string WeddingSpaceName { get; set; } = string.Empty;
}
