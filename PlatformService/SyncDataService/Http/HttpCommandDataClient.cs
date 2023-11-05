using System.Text;
using System.Text.Json;
using PlatformService.Dto_s;

namespace PlatformService.SyncDataService.Http;

public class HttpCommandDataClient : ICommandDataClient
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public HttpCommandDataClient(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _configuration = config;
    }

    public async Task SendPlatformToCommand(PlatformReadDto platform)
    {
        var httpContent = new StringContent(
            JsonSerializer.Serialize(platform),
            Encoding.UTF8,
            "application/json"
        );
        var response = await _httpClient.PostAsync($"{_configuration["CommandService"]}", httpContent);

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("--> Sync Post to command service was Ok");
        }
        else
        {
            Console.WriteLine("--> Sync Post to command service was Not Ok");
        }
    }
}