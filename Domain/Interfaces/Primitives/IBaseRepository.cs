namespace Domain.Repositories.Primitives;

using Domain.Entities.Primitives;

public interface IBaseRepository<T> where T : BaseEntity
{

    IQueryable<T> GetAll();

    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task AddAsync(T entity, CancellationToken cancellationToken = default);

    void Update(T entity);

    void Remove(T entity);

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}