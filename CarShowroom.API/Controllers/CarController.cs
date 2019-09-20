using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarShowroom.Domain.Interfaces;
using CarShowroom.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShowroom.API.Controllers
{
    /// <summary>
    /// Контроллер для работы с автомобилями
    /// </summary>
    [Route("CarShowroom/Car")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        /// <summary>
        /// Получение всех автомобилей
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public async Task<IEnumerable<CarModel>> GetAll()
        {
            return await _carService.GetAll();
        }

        /// <summary>
        /// Получение одного автомобиля
        /// </summary>
        /// <param name="guid">Уникальный идентификатор автомобиля</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<CarModel> GetCar(Guid guid)
        {
            return await _carService.GetCar(guid);
        }

        /// <summary>
        /// Добавление автомобиля
        /// </summary>
        /// <param name="carModel">Модель автомобиля</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> CreateCar([FromBody] CarModel carModel)
        {
            return await _carService.CreateCar(carModel);
        }

        /// <summary>
        /// Редактирование информации о автомобиле
        /// </summary>
        /// <param name="guid">Уникальный идентификатор автомобиля</param>
        /// <param name="carModel">Модель автомобиля</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<Guid> UpdateCar([FromBody] Guid guid, CarModel carModel)
        {
            return await _carService.UpdateCar(guid, carModel);
        }

        /// <summary>
        /// Удаление автомобиля
        /// </summary>
        /// <param name="guid">Уникальный идентификатор автомобиля</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task DeleteCar(Guid guid)
        {
            await _carService.DeleteCar(guid);
        }
    }
}