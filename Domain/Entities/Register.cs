using Domain.Entities.Primitives;

namespace Domain.Entities;

public class Register : BaseEntity
{
    public required Station Station { get; set; }

    public required Part Part { get; set; }

    public required DateTime DateTime { get; set; }
}