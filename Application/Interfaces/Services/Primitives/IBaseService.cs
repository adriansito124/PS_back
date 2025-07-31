namespace Domain.Services.Primitives;

using Domain.Entities.Primitives;

public interface IBaseService<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(Guid id);
    IEnumerable<T> GetAll();

    Task DeleteAsync(Guid id);
}