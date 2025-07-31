using Domain.Entities.Primitives;
using Domain.Enums;

namespace Domain.Entities;

public class Part : BaseEntity
{
    public required string SerialNumber { get; set; }
    public required EResult Status { get; set; }

    public required ICollection<Register> Registers { get; set; } = [];

}