using Domain.Entities.Primitives;

namespace Domain.Entities;

public class Part : BaseEntity
{
    public required string SerialNumber { get; set; }
    public required short Status { get; set; }

    public required ICollection<Register> Registers { get; set; } = [];

}