using System;

namespace CarShowroom.Domain.Models
{
    /// <summary>
    /// Модель автомобиля
    /// </summary>
    public class CarModel
    {
        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string RegistryNumber { get; set; }

        /// <summary>
        /// Марка
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Модель
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Объем двигателя
        /// </summary>
        public string EngineVolume { get; set; }

        /// <summary>
        /// Мощьность двигателя
        /// </summary>
        public string EnginePower { get; set; }

        /// <summary>
        /// Расход топлива
        /// </summary>
        public string FuelConsumption { get; set; }

        /// <summary>
        /// Количество дверей
        /// </summary>
        public string DoorsNumber { get; set; }

        /// <summary>
        /// Количество мест
        /// </summary>
        public string SeatsNumber { get; set; }

        /// <summary>
        /// Вместимость багажника
        /// </summary>
        public string VolumeTrunk { get; set; }

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