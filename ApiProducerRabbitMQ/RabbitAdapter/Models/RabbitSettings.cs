using RabbitMQ.Client;

namespace ApiProducerRabbitMQ.RabbitAdapter
{
    public class RabbitSettings
    {
        private  string RabbitConnect { get; set; }
        public readonly IConnection connect;
        public RabbitSettings()
        {
            this.connect = CreateConnection();
        }
        public IConnection CreateConnection()
        {
            //craindo conexão com rabbit
            var ConnectionFactory = new ConnectionFactory { Uri = new Uri("amqp://192.168.0.63:5672") };
            return ConnectionFactory.CreateConnection();
        }
    }
}