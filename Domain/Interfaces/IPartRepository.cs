namespace Domain.Interfaces;

using Domain.Entities;
using Domain.Repositories.Primitives;

public interface IPartRepository : IBaseRepository<Part>
{
    Task<IEnumerable<Part>> GetAllParts();
    Task<Part> GetPart();
}