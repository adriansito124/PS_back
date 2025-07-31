namespace Application.DTOs.Register;

using Application.DTOs.Station;
using Application.DTOs.Part;
using Domain.Entities;

public record StationRegisterDto(
    Guid Id,
    Guid? StationId,
    RegisterPartDto? RegisterPartDto
)
{
    // public static StationRegisterDto Map(Register obj)
    // {
    //     return new StationRegisterDto(
    //         obj.Id,
    //         obj.Station?.Id,
    //         obj.Part is null ? null : RegisterPartDto.Map(obj.Part)
    //     );
    // }
}