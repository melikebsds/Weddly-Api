using WeddingPlanner.Api.DTOs.Auth;

namespace WeddingPlanner.Api.Interfaces;

public interface IAuthService
{
    Task<AuthResponse> RegisterAsync(RegisterRequest request);

    Task<AuthResponse> LoginAsync(LoginRequest request);

    Task<UserResponse> GetCurrentUserAsync(Guid userId);
}
