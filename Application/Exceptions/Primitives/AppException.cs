using System.Net;

namespace Domain.Exceptions.Primitives;

public class AppException : Exception
{
    public int Status { get; }
    public string Title { get; }

    public AppException(string message, HttpStatusCode statusCode, string? type = null)
        : base(message)
    {
        Status = (int)statusCode;
        Title = statusCode.ToString();
    }

    public AppException(string message, HttpStatusCode statusCode, Exception inner, string? type = null)
        : base(message, inner)
    {
        Status = (int)statusCode;
        Title = statusCode.ToString();
    }
}