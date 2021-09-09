using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Shared.Models.Models;

namespace Customer.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Order : ControllerBase
    {
        private readonly IBus _busService;
        public Order(IBus busService)
        {
            _busService = busService;
        }

       

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Shared.Models.Models.Order order)
        {
            if (order != null)
            {
                order.OrderDate= DateTime.Now;
                
                Uri uri = new Uri("rabbitmq://localhost/orderQueue");
                var endPoint = await _busService.GetSendEndpoint(uri);
                await endPoint.Send(order);
                return Ok("Success");
            }
            return BadRequest();

           
        }
    }
}
