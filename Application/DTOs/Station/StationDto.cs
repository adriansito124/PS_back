namespace Application.DTOs.Station;

using Application.DTOs.Part;
using Application.DTOs.Register;
using Domain.Entities;

public record StationDto(
    Guid Id,
    string Name,
    short Index,
    IEnumerable<RegisterPartDto>? Registers
)
{
    public static StationDto Map(Station obj)
    {
        return new StationDto(
            obj.Id,
            obj.Name,
            obj.Index,
            obj.Registers?.Select(RegisterPartDto.Map)
        );
    }
}