namespace Application.DTOs.Part;

using Domain.Enums;
using Domain.Entities;
using Application.DTOs.Register;

public record RegisterPartDto(
    Guid Id,
    string SerialNumber
)
{
public static RegisterPartDto Map(Part obj)
    {
        return new RegisterPartDto(
            obj.Id,
            obj.SerialNumber
        );
    }

    public static RegisterPartDto Map(Register obj)
    {
        return new RegisterPartDto(
            obj.Part.Id,
            obj.Part.SerialNumber
        );
    }
}