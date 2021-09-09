using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models.Models;
using Customer.Microservice.Controllers;

namespace Order.Microservice.Consumers
{
    public class ConsumerOrder : IConsumer<Shared.Models.Models.Order>
    {
        public Task Consume(ConsumeContext<Shared.Models.Models.Order> context)
        {
            var data = context.Message;
            return Task.CompletedTask;
        }
    }
}
