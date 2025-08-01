using Application.DTOs.Register;
using Application.Exceptions;
using Application.Interfaces.Services;
using Application.Services.Primitives;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class RegisterService(
    IRegisterRepository repository,
    IStationRepository stationRepository, IPartRepository partRepository
) : BaseService<Register>(repository), IRegisterService
{
    private readonly IStationRepository _stationRepo = stationRepository;
    private readonly IPartRepository _partRepo = partRepository;
    public async Task<RegisterDto> CreateRegister(Guid stationId, CreateRegisterPayload payload)
    {
        var station = await _stationRepo.GetByIdAsync(stationId)
            ?? throw new NotFoundException("Station not found.");

        var stations = await _stationRepo.GetAll()
            .OrderBy(s => s.Index)
            .ToListAsync();

        var part = await _partRepo.GetAll()
            .Where(p => p.SerialNumber == payload.SerialNumber)
            .SingleOrDefaultAsync();

        if (stationId == stations.First().Id)
        {
            if (part is not null)
                throw new BadRequestException("Serial number already registered.");

            part = new Part()
            {
                SerialNumber = payload.SerialNumber
            };
        }
        else if (part is null)
        {
            throw new BadRequestException("Serial number not found.");
        }

        if (stationId == stations.Last().Id)
            part.Status = EResult.FINISHED;

        var register = new Register()
        {
            Station = station,
            Part = part,
            DateTime = DateTime.UtcNow
        };

        await _repo.AddAsync(register);
        await _repo.SaveChangesAsync();

        return RegisterDto.Map(register);
    }
}
