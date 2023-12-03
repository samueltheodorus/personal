using AutoMapper;
using XYZStore.Service.CustomerAPI.Models;
using XYZStore.Service.CustomerAPI.Models.Dto;

namespace XYZStore.Service.CustomerAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CustomerDto, Customer>();
                config.CreateMap<Customer, CustomerDto>();
            });
            return mappingConfig;
        }
    }
}
