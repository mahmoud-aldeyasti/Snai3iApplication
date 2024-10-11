using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai3i_BLL.DTO.OrderDto;
using Snai3i_BLL.Manager.OrdersManager;

namespace Snai3i_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderManager _orderManager;

        public OrderController(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        // POST: api/order
        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderAddDTO orderAddDTO)
        {
            await _orderManager.AddOrderAsync(orderAddDTO);
            return Ok("Order created successfully");
        }

        // GET: api/order/worker/{workerId}
        [HttpGet("{workerId}")]
        public async Task<IActionResult> GetOrdersForWorker(string workerId)
        {
            var orders = await _orderManager.GetOrdersForWorkerAsync(workerId);
            return Ok(orders);
        } 

        // PUT: api/order/{orderId}/confirm
        //[HttpPut("{orderId}/confirm")]
        //public async Task<IActionResult> ConfirmOrder(int orderId)
        //{
        //    await _orderService.ConfirmOrderAsync(orderId, DateTime.UtcNow);
        //    return Ok("Order confirmed successfully");
        //}
    }
}
