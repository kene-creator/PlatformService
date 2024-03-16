using PlatformService.Dto_s;

namespace PlatformService.AsyncDataService
{
    public class MessageBusClient : IMessageBusClient
    {
        private readonly IConfiguration _configuration;

        public MessageBusClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void PublishNewPLatform(PlatformPublishDto platformPublishDto)
        {
            throw new NotImplementedException();
        }
    }
}