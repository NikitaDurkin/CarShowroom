using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarShowroom.Domain.Models;

namespace CarShowroom.Domain.Interfaces
{
    /// <summary>
    /// Сервис по работе с заказами
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Получение всех заказов
        /// </summary>
        /// <returns></returns>
        Task<List<OrderModel>> GetAll();

        /// <summary>
        /// Получение информации о заказе
        /// </summary>
        /// <param name="guid">Уникальный идентификатор заказа</param>
        /// <returns></returns>
        Task<OrderModel> GetOrder(Guid guid);

        /// <summary>
        /// Добавление заказа
        /// </summary>
        /// <param name="orderModel">Модель заказа</param>
        /// <returns></returns>
        Task<Guid> CreateOrder(OrderModel orderModel);

        /// <summary>
        /// Редактирование информации о заказе
        /// </summary>
        /// <param name="guid">Уникальный идентификатор заказа</param>
        /// <param name="orderModel">Модель заказа</param>
        /// <returns></returns>
        Task<Guid> UpdateOrder(Guid guid, OrderModel orderModel);
    }
}