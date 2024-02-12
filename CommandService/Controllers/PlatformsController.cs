using AutoMapper;
using CommandService.Data;
using Microsoft.AspNetCore.Mvc;

namespace PlatformService.Controllers;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformsController : ControllerBase
{
    private readonly ICommandRepo _repository;
    private readonly IMapper _mapper;

    public PlatformsController(ICommandRepo repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpPost]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("--> Test inbound connection");

        return Ok("inbound test from Platforms controller");
    }
}