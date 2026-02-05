using AutoMapper;
using GeekShopping.ProdutctAPI.Contracts.DTOs;
using GeekShopping.ProdutctAPI.Model;

namespace GeekShopping.ProdutctAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
