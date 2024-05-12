using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthCare.API.Endpoints;

[Route("api/[controller]")]
[ApiController]
public class AccountController(ILogger<AccountController> logger) : ControllerBase
{
    private readonly ILogger<AccountController> logger = logger;

    [HttpGet("Logs")]
    public IActionResult TestLogs()
    {
        logger.LogDebug("Testing Failed");
        logger.LogWarning("Hey");
        logger.LogInformation("Ali Testing this Logs");
        return Ok();
    }
}
