namespace Application.Repositories;

using Domain.Entities;
using Application.Repositories.Primitives;

public interface IStationRepository : IBaseRepository<Station>
{
    Task<IEnumerable<Station>> GetAllStations();
    Task<Station> GetStation();
}