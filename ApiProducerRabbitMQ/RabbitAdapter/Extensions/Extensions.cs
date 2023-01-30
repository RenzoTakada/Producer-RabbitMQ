namespace ApiProducerRabbitMQ.RabbitAdapter
{
    public static class Extensions
    {
        public static IServiceCollection AddRabbitMq(this IServiceCollection service)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json").Build();
            service.AddSingleton<RabbitSettings>();
            service.AddSingleton(x => configuration.GetSection("RabbitMq").Get<RabbitSettings>());
            return service;

        }
    }
}
