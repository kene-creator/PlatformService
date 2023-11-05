using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dto_s;
using PlatformService.Models;
using PlatformService.SyncDataService.Http;

namespace PlatformService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlatformsController : ControllerBase
{
    private readonly IPlatformRepo _repository;
    private readonly IMapper _mapper;
    private readonly ICommandDataClient _commandDataClient;

    public PlatformsController(IPlatformRepo repository, IMapper mapper, ICommandDataClient commandDataClient)
    {
        _repository = repository;
        _mapper = mapper;
        _commandDataClient = commandDataClient;
    }

    [HttpGet]
    public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
    {
        Console.WriteLine("--> Getting Platforms");
        var platforms = _repository.GetPlatforms();

        return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platforms));
    }

    [HttpGet("{id}", Name = "GetPlatformById")]
    public ActionResult<PlatformReadDto> GetPlatformById(int id)
    {
        Console.WriteLine($"--> Getting Platform by ID: {id}");
        var platform = _repository.GetPlatformBYId(id);

        if (platform == null)
        {
            return NotFound();
        }

        return Ok(_mapper.Map<PlatformReadDto>(platform));
    }

    [HttpPost]
    public async Task<ActionResult<PlatformReadDto>> CreatePlatform(PlatformCreateDto platformCreateDto)
    {
        var platform = _mapper.Map<Platform>(platformCreateDto);
        _repository.CreatePlatform(platform);
        _repository.SaveChanges();

        var platfromReadDto = _mapper.Map<PlatformReadDto>(platform);

        try
        {
            await _commandDataClient.SendPlatformToCommand(platfromReadDto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
        return CreatedAtAction(nameof(GetPlatformById), new { id = platfromReadDto.Id }, platfromReadDto);
    }
}