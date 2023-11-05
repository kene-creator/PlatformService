﻿using PlatformService.Models;

namespace PlatformService.Data;

public interface IPlatformRepo
{
    bool SaveChanges();

    IEnumerable<Platform> GetPlatforms();

    Platform GetPlatformBYId(int id);

    void CreatePlatform(Platform platform);
}