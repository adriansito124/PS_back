namespace Domain.Interfaces;

using Domain.Entities;
using Domain.Repositories.Primitives;

public interface IStationRepository : IBaseRepository<Station>
{
    Task<IEnumerable<Station>> GetAllStations();
    Task<Station> GetStation();
}