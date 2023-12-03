using AutoMapper;
using XYZStore.Services.CouponAPI.Models;
using XYZStore.Services.CouponAPI.Models.Dto;

namespace XYZStore.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
