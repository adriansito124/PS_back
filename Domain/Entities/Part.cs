using Domain.Entities.Primitives;
using Domain.Enums;

namespace Domain.Entities;

public class Part : BaseEntity
{
    public required string SerialNumber { get; set; }
    public EResult Status { get; set; } = EResult.PROGRESS;

    public ICollection<Register> Registers { get; set; } = [];

}