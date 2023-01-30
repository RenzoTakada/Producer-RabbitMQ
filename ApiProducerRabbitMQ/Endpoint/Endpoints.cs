using ApiProducerRabbitMQ.Core.Application.UserCase;
using ApiProducerRabbitMQ.Core.Domain.EntitiesValue;
using System.Runtime.CompilerServices;

namespace ApiProducerRabbitMQ.Endpoint
{
    public static class Endpoints
    {
        public  static WebApplication AddEndpoints(this WebApplication app)
        {
            app.MapPost("Publish", async Task<IResult> (IUserCasePublishMessage usercase, MessageInputRequest request) =>
            {
                return Results.Ok(await usercase.RabbitMessageUSC(request));
            });

            return app;
        }
    }
}
