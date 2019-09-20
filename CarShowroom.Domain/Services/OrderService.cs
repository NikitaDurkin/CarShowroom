using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarShowroom.Domain.Interfaces;
using CarShowroom.Domain.Models;

namespace CarShowroom.Domain.Services
{
    /// <inheritdoc/>
    public class OrderService : IOrderService
    {
        /// <inheritdoc/>
        public Task<List<OrderModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<OrderModel> GetOrder(Guid guid)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Guid> CreateOrder(OrderModel orderModel)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Guid> UpdateOrder(Guid guid, OrderModel orderModel)
        {
            throw new NotImplementedException();
        }
    }
}