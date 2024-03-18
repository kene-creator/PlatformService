using PlatformService.Dto_s;
using RabbitMQ.Client;

namespace PlatformService.AsyncDataService
{
    public class MessageBusClient : IMessageBusClient
    {
        private readonly IConfiguration _configuration;

        public MessageBusClient(IConfiguration configuration)
        {
            _configuration = configuration;
            var factory = new ConnectionFactory() { HostName = _configuration["RabbitMQHost"], Port = int.Parse(_configuration["RabbitMQPort"]) };

            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not connect to RabbitMQ: {ex.Message}");
            }
        }
        public void PublishNewPLatform(PlatformPublishDto platformPublishDto)
        {
            throw new NotImplementedException();
        }
    }
}