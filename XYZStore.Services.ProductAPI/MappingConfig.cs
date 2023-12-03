using AutoMapper;
using XYZStore.Services.ProductAPI.Models;
using XYZStore.Services.ProductAPI.Models.Dto;

namespace XYZStore.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
