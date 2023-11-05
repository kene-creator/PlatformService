using PlatformService.Dto_s;

namespace PlatformService.SyncDataService.Http;

public interface ICommandDataClient
{
    Task SendPlatformToCommand(PlatformReadDto platform);
}