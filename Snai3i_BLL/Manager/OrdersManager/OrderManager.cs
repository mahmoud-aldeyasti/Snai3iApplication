using Microsoft.AspNetCore.Http;
using Snai3i_BLL.DTO.OrderDto;
using Snai3i_DAL.Data.Models;
using Snai3i_DAL.Data.Repository.OrdersRepository;
using Snai3i_DAL.Data.Repository.UserWorkerTransactionUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.OrdersManager
{
    public class OrderManager : IOrderManager
    {
        private readonly IUserWorkerTransactionUnitOfWork _userWorkerTransaction;
        private readonly IHttpContextAccessor _httpContextAccessor;

        //private readonly IOrdersRepository _orderRepository;

        public OrderManager(IUserWorkerTransactionUnitOfWork userWorkerTransaction,
            IHttpContextAccessor httpContextAccessor)
        {
            //_orderRepository = orderRepository;
            _userWorkerTransaction = userWorkerTransaction;
            _httpContextAccessor = httpContextAccessor;
        }

        // Add a new order
        public async Task AddOrderAsync(OrderAddDTO orderAddDTO)
        {
            try
            {
                //var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                //var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
                var order = new Order
                {
                    
                    UserId = orderAddDTO.UserId,
                    WorkerId = orderAddDTO.WorkerId,
                    Value = orderAddDTO.Value,
                    Commision = orderAddDTO.Commission,
                    ForwardDate = orderAddDTO.ForwardDate
                };

                _userWorkerTransaction.CreateTransaction();

                await _userWorkerTransaction.Orderss.InsertAsync(order);

                await _userWorkerTransaction.Save();
                _userWorkerTransaction.Commit();
            }
            catch (Exception ex)
            {
                _userWorkerTransaction.Rollback();
            }
        }

        // Get orders for a specific worker
        public async Task<IEnumerable<OrderReadDTO>> GetOrdersForWorkerAsync(string workerId)
        {
            var orders = await _userWorkerTransaction.Orderss.GetOrdersForWorkerAsync(workerId);
            if (orders == null)
            {
                throw new Exception("worker not found");
            }
            return orders.Select(o => new OrderReadDTO
            {
                Id = o.Id,
                ForwardDate = o.ForwardDate,
                ConfirmDate = o.ConfirmDate,
                //UserName = o.user.UserName,
                WorkerName = o.worker.UserName,
                Value = o.Value,
                Commission = o.Commision
            }).ToList();
        }

        // Confirm an order
        //public async Task ConfirmOrderAsync(int orderId, DateTime confirmDate)
        //{
        //    await _orderRepository.ConfirmOrderAsync(orderId, confirmDate);
        //}
    }
}
