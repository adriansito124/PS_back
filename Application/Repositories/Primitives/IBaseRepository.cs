namespace Application.Repositories.Primitives;

using Domain.Entities.Primitives;

public interface IBaseRepository<T> where T : BaseEntity
{

    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task AddAsync(T entity, CancellationToken cancellationToken = default);

    void Update(T entity);

    void Remove(T entity);
}