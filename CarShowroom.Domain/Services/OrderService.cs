using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarShowroom.Database;
using CarShowroom.Database.Models;
using CarShowroom.Domain.Interfaces;
using CarShowroom.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShowroom.Domain.Services
{
    /// <inheritdoc/>
    public class OrderService : IOrderService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public OrderService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc/>
        public async Task<List<OrderModel>> GetAll()
        {
            var result = await _context.Orders.ToListAsync();
            return _mapper.Map<List<Order>, List<OrderModel>>(result);
        }

        /// <inheritdoc/>
        public async Task<OrderModel> GetOrder(Guid guid)
        {
            var result = await _context.Orders.FindAsync(guid);
            return _mapper.Map<OrderModel>(result);
        }

        /// <inheritdoc/>
        public async Task<Guid> CreateOrder(OrderModel orderModel)
        {
            var result = _mapper.Map<Order>(orderModel);
            _context.Orders.Add(result);
            await _context.SaveChangesAsync();
            return result.Guid;
        }

        /// <inheritdoc/>
        public async Task<Guid> UpdateOrder(Guid guid, OrderModel orderModel)
        {
            Order order = _context.Orders.Find(guid);
            order.DateTime = orderModel.DateTime;
            order.Client = orderModel.Client;
            order.TestDrive = orderModel.TestDrive;
            order.Status = orderModel.Status;
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return order.Guid;
        }

        public async Task DeleteOrder(Guid guid)
        {
            var result = await _context.Orders.FindAsync(guid);
            _context.Orders.Remove(result); 
            await _context.SaveChangesAsync();
        }
    }
}