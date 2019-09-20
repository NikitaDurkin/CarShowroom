using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarShowroom.Domain.Models;

namespace CarShowroom.Domain.Interfaces
{
    /// <summary>
    /// Сервис по работе с автомобилями
    /// </summary>
    public interface ICarService
    {
        /// <summary>
        /// Получение всех автомобилей
        /// </summary>
        /// <returns></returns>
        Task<List<CarModel>> GetAll();

        /// <summary>
        /// Получение одного автомобиля
        /// </summary>
        /// <param name="guid">Уникальный идентификатор автомобиля</param>
        /// <returns></returns>
        Task<CarModel> GetCar(Guid guid);

        /// <summary>
        /// Добаваление автомобиля
        /// </summary>
        /// <param name="carModel">Модель автомобия</param>
        /// <returns></returns>
        Task<Guid> CreateCar(CarModel carModel);

        /// <summary>
        /// Редактирование информации о автомобиле
        /// </summary>
        /// <param name="guid">Уникальный идентификатор автомобиля</param>
        /// <param name="carModel">Модель автомобия</param>
        /// <returns></returns>
        Task<Guid> UpdateCar(Guid guid, CarModel carModel);

        /// <summary>
        /// Удаление автомобиля
        /// </summary>
        /// <param name="guid">Уникальный идентификатор автомобиля</param>
        /// <returns></returns>
        Task DeleteCar(Guid guid);
    }
}