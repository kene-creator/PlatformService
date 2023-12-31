﻿using System.Text;
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

        Console.WriteLine(response.IsSuccessStatusCode
            ? "--> Sync Post to command service was Ok"
            : "--> Sync Post to command service was Not Ok");
    }
}