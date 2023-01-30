using ApiProducerRabbitMQ.Core.Domain.EntitiesValue;

namespace ApiProducerRabbitMQ.Core.Application.UserCase
{
    public interface IUserCasePublishMessage
    {
        public Task<string> RabbitMessageUSC(MessageInputRequest request);
    }
}
