using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Api.DTOs.Auth;

public class RegisterRequest
{
    [Required(ErrorMessage = "Ad boş olamaz")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress(ErrorMessage = "Email geçerli olmalıdır")]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(6, ErrorMessage = "Şifre minimum 6 karakter olmalıdır")]
    public string Password { get; set; } = string.Empty;
}
