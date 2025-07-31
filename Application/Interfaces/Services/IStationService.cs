namespace Domain.Services;

using Domain.Entities;
using Domain.Services.Primitives;
using Application.DTOs.Station;


public interface IStationService : IBaseService<Station>
{
    Task<StationDto> CreateStation(CreateStationPayload payload);
    Task<StationDto> UpdateStation(Guid id, UpdateStationPayload payload);
    Task<IEnumerable<Station>> GetAllStations();
}