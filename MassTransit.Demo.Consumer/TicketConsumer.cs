using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace MassTransit.Demo.Consumer
{
    public class TicketConsumer : IConsumer<Ticket>
    {
        private readonly ILogger<TicketConsumer> logger;

        public TicketConsumer(ILogger<TicketConsumer> logger)
        {
            this.logger = logger;
        }

        public async Task Consume(ConsumeContext<Ticket> context)
        {
            await Console.Out.WriteLineAsync(context.Message.UserName);

            logger.LogInformation(
                "Nova mensagem recebida: {0} {1}", 
                context.Message.UserName, 
                context.Message.Location);
        }
    }
}
