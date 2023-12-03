using AutoMapper;
using XYZStore.Services.OrderAPI.Models;
using XYZStore.Services.OrderAPI.Models.Dto;

namespace XYZStore.Services.OrderAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<OrderDto, Order>();
                config.CreateMap<Order, OrderDto>();
            });
            return mappingConfig;
        }
    }
}
