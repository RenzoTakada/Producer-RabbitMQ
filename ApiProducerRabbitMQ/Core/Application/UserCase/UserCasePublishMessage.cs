using ApiProducerRabbitMQ.Core.Domain.EntitiesValue;
using ApiProducerRabbitMQ.RabbitAdapter;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace ApiProducerRabbitMQ.Core.Application.UserCase
{
    public class UserCasePublishMessage : IUserCasePublishMessage
    {
        private readonly IModel model;
        private readonly string nameQuery = "informacoesConta";
        public UserCasePublishMessage(RabbitSettings rabbitSettings)
        {
            model = rabbitSettings.connect.CreateModel();
            
        }
        public async Task<string> RabbitMessageUSC(MessageInputRequest request)
        {
           var messageJson = JsonSerializer.Serialize(request);
            publish(messageJson);
            return $"Mensagem publicada {messageJson}";

        }
        public void publish (string message)
        {
            model.BasicPublish(exchange: "Conta", routingKey: nameQuery, basicProperties: null, body: Encoding.UTF8.GetBytes(message));
        }

    }
}
