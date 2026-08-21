using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Api.DTOs.WeddingSpaces;

public class CreateWeddingSpaceRequest
{
    [Required(ErrorMessage = "Hazırlık alanı adı boş olamaz")]
    public string Name { get; set; } = string.Empty;

    public DateTime? WeddingDate { get; set; }
}

public class UpdateWeddingSpaceRequest
{
    [Required(ErrorMessage = "Hazırlık alanı adı boş olamaz")]
    public string Name { get; set; } = string.Empty;

    public DateTime? WeddingDate { get; set; }
}
