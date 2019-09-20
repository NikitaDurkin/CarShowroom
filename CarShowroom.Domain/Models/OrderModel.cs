using System;

namespace CarShowroom.Domain.Models
{
    /// <summary>
    /// Модель заказа
    /// </summary>
    public class OrderModel
    {
        /// <summary>
        /// Уникальный идентификатор заказа
        /// </summary>
        public Guid Guid { get; set; }
        
        /// <summary>
        /// Дата и время
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Клиент
        /// </summary>
        public Guid Client { get; set; }

        /// <summary>
        /// Нужен ли тест-драйв
        /// </summary>
        public bool TestDrive { get; set; }

        /// <summary>
        /// Текущий статус
        /// </summary>
        public string Status { get; set; }
    }
}