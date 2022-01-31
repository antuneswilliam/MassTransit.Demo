using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MassTransit.Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IBus bus;

        public OrderController(IBus bus)
        {
            this.bus = bus;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(Ticket ticket)
        {
            if (ticket == null)
                return BadRequest();
            
            ticket.Booked = DateTime.Now;

            var uri = new Uri("rabbitmq://localhost/orderTicketQueue");
            var endpoint = await bus.GetSendEndpoint(uri);
            await endpoint.Send(ticket);

            return Ok();

        }
    }
}
