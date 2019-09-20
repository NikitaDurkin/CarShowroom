using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarShowroom.Database.Models
{
    /// <summary>
    /// Модель клиента
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        [Key]
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
        public List<Order> Orders { get; set; }
    }
}