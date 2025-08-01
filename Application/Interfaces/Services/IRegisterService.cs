using Application.DTOs.Register;
using Domain.Entities;
using Domain.Services.Primitives;

namespace Application.Interfaces.Services;

public interface IRegisterService : IBaseService<Register>
{
    Task<RegisterDto> CreateRegister(Guid stationId, CreateRegisterPayload payload);
}