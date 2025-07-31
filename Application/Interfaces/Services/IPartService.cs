using Application.DTOs.Part;
using Domain.Entities;
using Domain.Enums;
using Domain.Services.Primitives;

namespace Domain.Services;

public interface IPartService : IBaseService<Part>
{
    Task<Part> CreatePartAsync(CreatePartPayload payload);
    Task<Part> UpdatePartStatusAsync(Guid id, EResult status);

}
