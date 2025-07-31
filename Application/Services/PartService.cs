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
    IPartRepository repository, IStationRepository stationRepository
) : BaseService<Part>(repository), IPartService
{
    private readonly IPartRepository _repo = repository;
    private readonly IStationRepository _stationRepo = stationRepository;

    public async Task<Part> CreatePartAsync(CreatePartPayload payload)
    {
        var station = await _stationRepo.GetByIdAsync(payload.StationId)
            ?? throw new NotFoundException("Station not found");

        var part = new Part
        {
            SerialNumber = payload.SerialNumber,
            Status = EResult.PROGRESS,
            Registers = []
        };

        await repository.AddAsync(part);
        await repository.SaveChangesAsync();

        return part;
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