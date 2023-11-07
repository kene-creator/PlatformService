using Microsoft.AspNetCore.Mvc;

namespace PlatformService.Controllers;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformsController : ControllerBase
{
    public PlatformsController()
    {
        
    }

    [HttpPost]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("--> Test inbound connection");

        return Ok("inbound test from Platforms controller");
    }
}