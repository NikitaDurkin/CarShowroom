using System;
using System.ComponentModel.DataAnnotations;

namespace CarShowroom.Database.Models
{
    /// <summary>
    /// Заказы
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа
        /// </summary>
        [Key]
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