using Application.DTOs.Station;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("stations")]
public class StationController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllStations(
        [FromServices] IStationService service
    )
    {
        var result = await service.GetAllStations();
        return Ok(result.Select(StationDto.Map));
    }

    [HttpPost]
    public async Task<IActionResult> CreateStation(
        [FromServices] IStationService service, [FromBody] CreateStationPayload payload
    )
    {
        var result = await service.CreateStation(payload);
        return Created("stations", result);
    }

    [HttpPatch]
    [Route("{id}")]
    public async Task<IActionResult> UpdateStation(
        [FromServices] IStationService service, [FromBody] UpdateStationPayload payload, Guid id
    )
    {
        var result = await service.UpdateStation(id, payload);
        return Ok(result);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteStation(
        [FromServices] IStationService service, Guid id
    )
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}