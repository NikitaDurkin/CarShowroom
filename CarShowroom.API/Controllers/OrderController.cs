using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarShowroom.Domain.Interfaces;
using CarShowroom.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShowroom.API.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Получение всех заказов
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public async Task<IEnumerable<OrderModel>> GetAll()
        {
            return await _orderService.GetAll();
        }

        /// <summary>
        /// Получение одного заказа
        /// </summary>
        /// <param name="guid">Уникальный идентификатор заказа</param>
        /// <returns></returns>
        [HttpGet("GetOrder")]
        public async Task<OrderModel> GetOrder(Guid guid)
        {
            return await _orderService.GetOrder(guid);
        }

        /// <summary>
        /// Создание заказа
        /// </summary>
        /// <param name="orderModel">Модель заказа</param>
        /// <returns></returns>
        [HttpPost("CreateOrder")]
        public async Task<Guid> CreateOrder(OrderModel orderModel)
        {
            return await _orderService.CreateOrder(orderModel);
        }

        /// <summary>
        /// Редактирование информации о заказе
        /// </summary>
        /// <param name="guid">Уникальный идентификатор заказа</param>
        /// <param name="orderModel">Модель заказа</param>
        /// <returns></returns>
        [HttpPut("UpdateOrder")]
        public async Task<Guid> UpdateOrder(Guid guid, OrderModel orderModel)
        {
            return await _orderService.UpdateOrder(guid, orderModel);
        }

        /// <summary>
        /// Удаление заказа
        /// </summary>
        /// <param name="guid">Уникальный идентификатор заказа</param>
        /// <returns></returns>
        [HttpDelete("DeleteOrder")]
        public async Task DeleteOrder(Guid guid)
        {
            await _orderService.DeleteOrder(guid);
        }
    }
}