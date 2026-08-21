using System.Net;

namespace WeddingPlanner.Api.Common;

/// <summary>
/// İş kuralı ihlallerinde fırlatılır; ExceptionMiddleware bunu uygun HTTP status koduna çevirir.
/// </summary>
public class AppException : Exception
{
    public HttpStatusCode StatusCode { get; }

    public AppException(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        : base(message)
    {
        StatusCode = statusCode;
    }
}
