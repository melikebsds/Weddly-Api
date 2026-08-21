using System.ComponentModel.DataAnnotations;
using WeddingPlanner.Api.Entities;

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

    public WeddingTaskStatus Status { get; set; } = WeddingTaskStatus.ToBuy;
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

    public WeddingTaskStatus Status { get; set; }
}

public class SetTaskStatusRequest
{
    public WeddingTaskStatus Status { get; set; }
}
