namespace Application.Services;
using Application.Services;
using Application.DTOs.Part;
using Application.Services.Primitives;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;
using Domain.Exceptions;
using Domain.Enums;
using System.Collections.Generic;
using System;

public class PartService(
    IPartRepository repository, IStationRepository stationRepository, IRegisterRepository registerRepository
) : BaseService<Part>(repository), IPartService
{
    private readonly IPartRepository _repo = repository;
    private readonly IStationRepository _stationRepo = stationRepository;
    private readonly IRegisterRepository _registerRepo = registerRepository;

    public async Task<RegisterPartDto> CreatePartAsync(CreatePartPayload payload)
    {
        var station = await _stationRepo.GetByIdAsync(payload.StationId)
            ?? throw new NotFoundException("Station not found");

        var part = new Part
        {
            SerialNumber = payload.SerialNumber,
            Status = EResult.PROGRESS,
        };

        var register = new Register
        {
            Station = station,
            Part = part,
            DateTime = DateTime.UtcNow
        };

        await _registerRepo.AddAsync(register);
        await _registerRepo.SaveChangesAsync();

        part.Registers.Add(register);

        return RegisterPartDto.Map(part);
    }

    public async Task<Part> UpdatePartStatusAsync(Guid id, EResult status)
    {
        var part = await _repo.GetByIdAsync(id)
            ?? throw new NotFoundException("Part not found");

        part.Status = status;

        _repo.Update(part);
        await _repo.SaveChangesAsync();

        return part;
    }
}