using System;

namespace MassTransit.Demo
{
    public class Ticket
    {
        public string UserName { get; set; }
        public DateTime Booked { get; set; }
        public string Location { get; set; }
    }
}
