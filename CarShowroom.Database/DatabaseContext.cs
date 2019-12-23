using System;
using System.Collections.Generic;
using CarShowroom.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShowroom.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var car = new Car
            {
                Guid = Guid.NewGuid(),
                RegistryNumber = "А000АА00",
                Brand = "Toyota",
                Model = "Camry",
                Manufacturer = "Япония",
                EngineVolume = "2.4",
                EnginePower = "167",
                FuelConsumption = "12",
                DoorsNumber = "5",
                SeatsNumber = "5",
                VolumeTrunk = "300",
                AutomaticTransmission = true,
                CruiseControl = true,
                Fuel = "АИ-95",
                Conditioner = true,
                Radio = true,
                Video = true,
                GpsNavigator = true,
                Interior = "Leather",
                Color = "Black",
                Milage = "200000",
                TO = DateTime.Now.AddMonths(-6),
                Price = "600000",
                Client = "Иванов Иван Иванович"
            };

            var car1 = new Car
            {
                Guid = Guid.NewGuid(),
                RegistryNumber = "А111АА11",
                Brand = "Mecedes-Benz",
                Model = "E-classe",
                Manufacturer = "Германия",
                EngineVolume = "5.0",
                EnginePower = "345",
                FuelConsumption = "20",
                DoorsNumber = "5",
                SeatsNumber = "5",
                VolumeTrunk = "300",
                AutomaticTransmission = false,
                CruiseControl = true,
                Fuel = "АИ-95",
                Conditioner = true,
                Radio = true,
                Video = true,
                GpsNavigator = true,
                Interior = "Leather",
                Color = "Black",
                Milage = "200000",
                TO = DateTime.Now.AddMonths(-6),
                Price = "600000",
                Client = "Петров Петр Петрович"
            };
            
//            var client = new Client
//            {
//                Guid = Guid.NewGuid(),
//                FullName = "Иванов Иван Иванович",
//                Address = "г.Обнинск, ул. Ленина д.355 кв.1",
//                Email = "Ivanov@mail.ru",
//                Phone = "89999999999",
//                Orders = new List<Order>()
//            };
//            
//            var order = new Order
//            { 
//                DateTime = DateTimeOffset.Now,
//                Client = Guid.Parse("05f2193b-a72a-4d84-b80c-52bb1d60d8d1"),
//                TestDrive = true,
//                Status = "На тесте"
//            };

            modelBuilder.Entity<Car>().HasData(
                car,
                car1
                //client,
                //order
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}