using AutoMapper;
using ProductShop.DTO.Input;
using ProductShop.DTO.Output;
using ProductShop.Models;
using ProductShop.Models;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            CreateMap<UserInputDto, User>();

            CreateMap<ProductInputDto, Product>();

            CreateMap<CategoriseInputDto, Category>();

            CreateMap<CategoryProductInputDto, CategoryProduct>();

            CreateMap<Product, ProductsOutputDto>()
                .ForMember(dest=>dest.Seller,opt=>opt.MapFrom(scr=>$"{scr.Seller.FirstName} {scr.Seller.LastName}"));
        }
    }
}
