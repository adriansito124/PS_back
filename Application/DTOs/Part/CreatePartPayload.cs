using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Part;

public class CreatePartPayload
{
    [Required]
    [StringLength(255)]
    public required string SerialNumber { get; set; }
    
    [Required]
    public required Guid StationId { get; set; }
}
