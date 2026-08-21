using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Api.DTOs.Tasks;

public class CreateTaskRequest
{
    [Required(ErrorMessage = "Görev adı boş olamaz")]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Fiyat negatif olamaz")]
    public decimal? EstimatedPrice { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Fiyat negatif olamaz")]
    public decimal? ActualPrice { get; set; }

    public Guid? AssignedUserId { get; set; }

    public bool IsCompleted { get; set; }
}

public class UpdateTaskRequest
{
    [Required(ErrorMessage = "Görev adı boş olamaz")]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Fiyat negatif olamaz")]
    public decimal? EstimatedPrice { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Fiyat negatif olamaz")]
    public decimal? ActualPrice { get; set; }

    public Guid? AssignedUserId { get; set; }

    public bool IsCompleted { get; set; }
}

public class CompleteTaskRequest
{
    public bool IsCompleted { get; set; } = true;
}
