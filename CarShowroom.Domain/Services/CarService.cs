using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarShowroom.Database;
using CarShowroom.Database.Models;
using CarShowroom.Domain.Interfaces;
using CarShowroom.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShowroom.Domain.Services
{
    /// <inheritdoc/>
    public class CarService : ICarService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public CarService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc/>
        public async Task<List<CarModel>> GetAll()
        {
            var result = await _context.Cars.ToListAsync();
            return _mapper.Map<List<Car>, List<CarModel>>(result);
        }

        /// <inheritdoc/>
        public async Task<CarModel> GetCar(Guid guid)
        {
            var result = await _context.Cars.FindAsync(guid);
            return _mapper.Map<CarModel>(result);
        }

        /// <inheritdoc/>
        public async Task<Guid> CreateCar(CarModel carModel)
        {
            var result = _mapper.Map<Car>(carModel);
            _context.Cars.Add(result);
            await _context.SaveChangesAsync();
            return result.Guid;
        }

        /// <inheritdoc/>
        public async Task<Guid> UpdateCar(Guid guid, CarModel carModel)
        {
            Car car = _context.Cars.Find(guid);
            car.Brand = carModel.Brand;
            car.Model = carModel.Model;
            car.Client = carModel.Client;
            car.Color = carModel.Color;
            car.Conditioner = carModel.Conditioner;
            car.Fuel = carModel.Fuel;
            car.Interior = carModel.Interior;
            car.Manufacturer = carModel.Manufacturer;
            car.Milage = carModel.Milage;
            car.Price = carModel.Price;
            car.Radio = carModel.Radio;
            car.Video = carModel.Video;
            car.AutomaticTransmission = carModel.AutomaticTransmission;
            car.CruiseControl = carModel.CruiseControl;
            car.DoorsNumber = carModel.DoorsNumber;
            car.EnginePower = carModel.EnginePower;
            car.EngineVolume = carModel.EngineVolume;
            car.FuelConsumption = carModel.FuelConsumption;
            car.GpsNavigator = carModel.GpsNavigator;
            car.RegistryNumber = carModel.RegistryNumber;
            car.SeatsNumber = carModel.SeatsNumber;
            car.TO = carModel.TO;
            car.VolumeTrunk = carModel.VolumeTrunk;
            _context.Cars.Update(car);
            await _context.SaveChangesAsync();
            return car.Guid;
        }

        /// <inheritdoc/>
        public async Task DeleteCar(Guid guid)
        {
            var result = await _context.Cars.FindAsync(guid);
            _context.Cars.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}