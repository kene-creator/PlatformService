using AutoMapper;
using PlatformService.Dto_s;
using PlatformService.Models;

namespace PlatformService.Profiles;

public class PlatformProfile : Profile
{
    public PlatformProfile()
    {
        CreateMap<Platform, PlatformReadDto>();
        CreateMap<PlatformReadDto, Platform>();
    }
}