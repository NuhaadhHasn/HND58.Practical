using AutoMapper;
using ProductSales.API.DTO;
using ProductSales.API.Model;

namespace ProductSales.API.Profiles;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CustomerReadDTO>();
        CreateMap<CustomerCreateDTO, Customer>();
    }
}