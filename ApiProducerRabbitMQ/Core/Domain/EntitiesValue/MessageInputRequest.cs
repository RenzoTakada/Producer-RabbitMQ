namespace ApiProducerRabbitMQ.Core.Domain.EntitiesValue
{
    public class MessageInputRequest
    {
        public string title { get; set; }
        public int status { get; set; }
        public string information { get; set; }
        public DateTime dateAt { get; set; } = DateTime.UtcNow;

    }
}
