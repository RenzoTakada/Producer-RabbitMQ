namespace ApiProducerRabbitMQ.RabbitAdapter
{
    public static class Extensions
    {
        public static IServiceCollection AddRabbitMq(this IServiceCollection service)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json").Build();
            // RabbitSettings inst = new RabbitSettings();
            // configuration.Bind("RabbitMq", inst);
            service.AddSingleton<RabbitSettings>();
            service.AddSingleton(x => configuration.GetSection("RabbitMq").Get<RabbitSettings>());
            //  Console.WriteLine(inst.RabbitConnect);
            return service;

        }
    }
}
