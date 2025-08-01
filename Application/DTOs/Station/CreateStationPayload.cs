using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Station;

public class CreateStationPayload
{
    [Required]
    [StringLength(255)]
    public required string Name { get; init; }

    [Required]
    public required short Index { get; init; }
}