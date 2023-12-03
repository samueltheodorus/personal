using AutoMapper;
using XYZStore.Services.MerchantAPI.Models;
using XYZStore.Services.MerchantAPI.Models.Dto;

namespace XYZStore.Services.MerchantAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<MerchantDto, Merchant>();
                config.CreateMap<Merchant, MerchantDto>();
            });
            return mappingConfig;
        }
    }
}
