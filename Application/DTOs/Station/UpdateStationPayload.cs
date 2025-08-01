using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Station;

public class UpdateStationPayload
{
    [StringLength(255)]
    public string? Name { get; init; }

    public short? Index { get; init; }
}