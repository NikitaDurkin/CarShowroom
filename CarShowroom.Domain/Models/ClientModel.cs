using System;
using System.Collections.Generic;

namespace CarShowroom.Domain.Models
{
    /// <summary>
    /// Модель клиента
    /// </summary>
    public class ClientModel
    {
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public Guid Guid { get; set; }
        
        /// <summary>
        /// ФИО
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Сделанные заказы
        /// </summary>
        public List<OrderModel> Orders { get; set; }
    }
}