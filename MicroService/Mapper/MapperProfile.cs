using AutoMapper;
using MicroService.Models;
using MicroService.Models.Dto;

namespace MicroService.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ProductEntity, ProductDto>().ReverseMap();
            CreateMap<StorageEntity, StorageDto>().ReverseMap();
            CreateMap<CategoryEntity, CategoryDto>().ReverseMap();
        }
    }
}
