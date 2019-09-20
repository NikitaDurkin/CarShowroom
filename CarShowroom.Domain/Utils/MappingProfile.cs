using AutoMapper;
using CarShowroom.Database.Models;
using CarShowroom.Domain.Models;

namespace CarShowroom.Domain.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarModel>();
            CreateMap<CarModel, Car>();
            CreateMap<Client, ClientModel>();
            CreateMap<ClientModel, Client>();
            CreateMap<Order, OrderModel>();
            CreateMap<OrderModel, Order>();
        }
    }
}