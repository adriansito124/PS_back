using System.Net;
using Domain.Exceptions.Primitives;

namespace Application.Exceptions;

public class BadRequestException : AppException
{
    public BadRequestException(string message, string? type = null)
    : base(message, HttpStatusCode.BadRequest, type) { }

    public BadRequestException(string message, Exception inner, string? type = null)
        : base(message, HttpStatusCode.BadRequest, inner, type) { }
}