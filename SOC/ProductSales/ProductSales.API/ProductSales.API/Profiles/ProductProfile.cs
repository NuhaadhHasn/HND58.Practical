using AutoMapper;
using ProductSales.API.Model;
using ProductSales.API.DTO;
namespace ProductSales.API.Profiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductReadDTO>();
        CreateMap<ProductCreateDTO, Product>();
    }
}