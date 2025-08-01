using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Register;

public class CreateRegisterPayload
{
    [Required]
    public required string SerialNumber { get; init; }
}