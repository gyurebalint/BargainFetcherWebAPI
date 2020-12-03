using AutoMapper;
using BargainFetcher.Dtos;
using BargainFetcher.Models;

namespace BargainFetcher.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductCreateDto,Product>();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductUpdateDto>();
        }
    }
}