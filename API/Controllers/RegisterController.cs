using Application.DTOs.Register;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("registers")]
public class RegisterController : ControllerBase
{
    [HttpPost]
    [Route("{stationId}")]
    public async Task<IActionResult> CreateRegister(
        [FromServices] IRegisterService service, [FromBody] CreateRegisterPayload payload, Guid stationId
    )
    {
        var result = await service.CreateRegister(stationId, payload);
        return Ok(result);
    }
}