using Microsoft.AspNetCore.Mvc;

namespace Bff.Api.Status;

public class StatusController : ControllerBase
{
    // GET /status
    [HttpGet("/status")]
    public IActionResult GetTheStatus()
    {
        return Ok("Everything is groovy");
    }
}
