using Snai3i_BLL.DTO.OrderDto;
using Snai3i_BLL.DTO.ReviewDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Manager.OrdersManager
{
    public interface IOrderManager
    {
        public Task AddOrderAsync(OrderAddDTO orderAddDTO);
        Task<IEnumerable<OrderReadDTO>> GetOrdersForWorkerAsync(string workerId);
    }
}
