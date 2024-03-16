using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatformService.Dto_s;

namespace PlatformService.AsyncDataService
{
    public interface IMessageBusClient
    {
        void PublishNewPLatform(PlatformPublishDto platformPublishDto);
    }
}