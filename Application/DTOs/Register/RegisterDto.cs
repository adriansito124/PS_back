namespace Application.DTOs.Register;

using Domain.Entities;

public record RegisterDto(
    Guid Id,
    Guid StationId,
    Guid PartId,
    DateTime DateTime
)
{
    public static RegisterDto Map(Register obj)
    {
        return new RegisterDto(
            obj.Id,
            obj.Station.Id,
            obj.Part.Id,
            obj.DateTime
        );
    }
}