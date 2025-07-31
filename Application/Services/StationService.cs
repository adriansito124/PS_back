using Application.DTOs.Station;
using Application.Services.Primitives;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class StationService(
    IStationRepository repository, IRegisterRepository registerRepository
) : BaseService<Station>(repository), IStationService
{
    private readonly IStationRepository _repo = repository;
    private readonly IRegisterRepository _registerRepo = registerRepository;

    public async Task<IEnumerable<Station>> GetAllStations()
    {
        var stations = await _repo.GetAll()
            .OrderBy(s => s.Index)
            .ToListAsync();

        var registers = await _registerRepo.GetAll()
            .Include(r => r.Station)
            .Include(r => r.Part)
            .ToListAsync();

        stations[0].Registers = [];

        if (stations.Count > 1)
        {
            for (int i = 1; i < stations.Count; i++)
            {
                var currentStation = stations[i];
                var previousStation = stations[i - 1];

                currentStation.Registers = [.. registers.Where(r => r.Station.Id == previousStation.Id)];
            }
        }

        return stations;
    }

    public async Task<StationDto> CreateStation(CreateStationPayload payload)
    {
        var station = new Station
        {
            Name = payload.Name,
            Index = payload.Index
        };

        await _repo.AddAsync(station);
        await _repo.SaveChangesAsync();

        return StationDto.Map(station);
    }

    public async Task<StationDto> UpdateStation(Guid id, UpdateStationPayload payload)
    {
        var station = await _repo.GetByIdAsync(id)
            ?? throw new NotFoundException("Station not found.");

        station.Name = payload.Name ?? station.Name;
        station.Index = payload.Index ?? station.Index;

        await _repo.SaveChangesAsync();

        return StationDto.Map(station);
    }
}