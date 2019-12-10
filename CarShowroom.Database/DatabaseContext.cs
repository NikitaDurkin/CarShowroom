using System;
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
                Client = "Петров Петр Петрович"
            };

            modelBuilder.Entity<Car>().HasData(
                car,
                car1
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}