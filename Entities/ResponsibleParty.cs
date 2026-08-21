namespace WeddingPlanner.Api.Entities;

/// <summary>
/// Bir görev/ürünün kime ait olduğu (partnerli kullanım için).
/// </summary>
public enum ResponsibleParty
{
    Unspecified = 0,
    Bride = 1,
    Groom = 2,
    Both = 3,
}
