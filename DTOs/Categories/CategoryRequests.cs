using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Api.DTOs.Categories;

public class CreateCategoryRequest
{
    [Required(ErrorMessage = "Kategori adı boş olamaz")]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int Order { get; set; }
}

public class UpdateCategoryRequest
{
    [Required(ErrorMessage = "Kategori adı boş olamaz")]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int Order { get; set; }
}
