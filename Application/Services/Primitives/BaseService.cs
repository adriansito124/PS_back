using Application.Exceptions;
using Domain.Entities.Primitives;
using Domain.Exceptions;
using Domain.Repositories.Primitives;
using Domain.Services.Primitives;

namespace Application.Services.Primitives;

public class BaseService<T>(
    IBaseRepository<T> repository
) : IBaseService<T> where T : BaseEntity
{
    protected readonly IBaseRepository<T> _repo = repository;

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _repo.GetByIdAsync(id)
            ?? throw new NotFoundException($"Object with ID {id} not found.");

        _repo.Remove(entity);
        await _repo.SaveChangesAsync();
    }

    public virtual IEnumerable<T> GetAll()
        => _repo.GetAll();

    public async Task<T> GetByIdAsync(Guid id)
        => await _repo.GetByIdAsync(id)
            ?? throw new NotFoundException($"Object with ID {id} not found.");
}