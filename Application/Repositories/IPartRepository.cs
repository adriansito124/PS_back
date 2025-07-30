namespace Application.Repositories;

using Domain.Entities;
using Application.Repositories.Primitives;

public interface IPartRepository : IBaseRepository<Part>
{
    Task<IEnumerable<Part>> GetAllParts();
    Task<Part> GetPart();
}