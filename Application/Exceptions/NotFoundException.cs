using System.Net;
using Domain.Exceptions.Primitives;

namespace Application.Exceptions;

public class NotFoundException : AppException
{
    public NotFoundException(string message, string? type = null)
    : base(message, HttpStatusCode.NotFound, type) { }

    public NotFoundException(string message, Exception inner, string? type = null)
        : base(message, HttpStatusCode.NotFound, inner, type) { }
}