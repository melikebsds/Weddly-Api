using System.Security.Claims;

namespace WeddingPlanner.Api.Common;

public static class CurrentUser
{
    public static Guid GetUserId(ClaimsPrincipal principal)
    {
        var value = principal.FindFirstValue(ClaimTypes.NameIdentifier)
            ?? principal.FindFirstValue("sub");

        if (value == null || !Guid.TryParse(value, out var userId))
        {
            throw new AppException("Kullanıcı doğrulanamadı", System.Net.HttpStatusCode.Unauthorized);
        }

        return userId;
    }
}
