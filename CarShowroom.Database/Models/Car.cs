using System;
using System.ComponentModel.DataAnnotations;

namespace CarShowroom.Database.Models
{
    /// <summary>
    /// Модель автомобилей
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Уникальный идентификатор автомобиля
        /// </summary>
        [Key]
        public Guid Guid { get; set; }
        
        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string RegistryNumber { get; set; }

        /// <summary>
        /// Марка
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Объем двигателя
        /// </summary>
        public float EngineVolume { get; set; }

        /// <summary>
        /// Мощьность двигателя
        /// </summary>
        public float EnginePower { get; set; }

        /// <summary>
        /// Расход топлива
        /// </summary>
        public float FuelConsumption { get; set; }

        /// <summary>
        /// Количество дверей
        /// </summary>
        public int DoorsNumber { get; set; }

        /// <summary>
        /// Количество мест
        /// </summary>
        public int SeatsNumber { get; set; }

        /// <summary>
        /// Вместимость багажника
        /// </summary>
        public int VolumeTrunk { get; set; }

        /// <summary>
        /// Автоматическая коробка передач
        /// </summary>
        public bool AutomaticTransmission { get; set; }

        /// <summary>
        /// Круиз - контроль
        /// </summary>
        public bool CruiseControl { get; set; }

        /// <summary>
        /// Требуемое топливо
        /// </summary>
        public string Fuel { get; set; }

        /// <summary>
        /// Радио
        /// </summary>
        public bool Conditioner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Radio { get; set; }

        /// <summary>
        /// Видео
        /// </summary>
        public bool Video { get; set; }

        /// <summary>
        /// GPS - Навигатор
        /// </summary>
        public bool GpsNavigator { get; set; }

        /// <summary>
        /// Обивка салона
        /// </summary>
        public string Interior { get; set; }

        /// <summary>
        /// Цвет
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Пробег
        /// </summary>
        public string Milage { get; set; }

        /// <summary>
        /// Последнее ТО
        /// </summary>
        public DateTime TO { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Клиенты, проводившие тест-драйв
        /// </summary>
        public string Client { get; set; }
    }
}