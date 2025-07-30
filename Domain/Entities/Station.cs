using Domain.Entities.Primitives;

namespace Domain.Entities;

public class Station : BaseEntity
{
    public required string Name { get; set; }
    public required short Index { get; set; }

    public required ICollection<Register> Registers { get; set; } = [];
}