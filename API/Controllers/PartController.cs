using Application.DTOs.Part;
using Application.DTOs.Station;
using Domain.Enums;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("parts")]
public class PartCOntroller : ControllerBase
{
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetPartById(
        [FromServices] IPartService service, Guid id
    )
    {
        var part = await service.GetByIdAsync(id);
        return Ok(part);
    }


    [HttpPost]
    public async Task<IActionResult> CreatePart(
        [FromServices] IPartService service, [FromBody] CreatePartPayload payload
    )
    {
        var result = await service.CreatePartAsync(payload);
        return Created("parts", result);
    }

    [HttpPatch]
    [Route("{id}")]
    public async Task<IActionResult> UpdatePart(
        [FromServices] IPartService service, Guid id, EResult status
    )
    {
        var result = await service.UpdatePartStatusAsync(id, status);
        return Ok(result);
    }

    [HttpDelete]
    [Route("id")]
    public async Task<IActionResult> DeletePart(
        [FromServices] IPartService service, Guid id
    )
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}