namespace Domain.Entities.Primitives;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}