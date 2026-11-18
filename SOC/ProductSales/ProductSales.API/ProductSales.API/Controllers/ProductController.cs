using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductSales.API.Data;
using ProductSales.API.DTO;
using ProductSales.API.Model;

namespace ProductSales.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ProductController : Controller
{
    private readonly IMapper _mapper;

    private readonly IProductRepo _productRepo;

    public ProductController(IProductRepo repo, IMapper mapper)
    {
        _mapper = mapper;
        _productRepo = repo;
    }

    [HttpPost]
    public ActionResult CreateProduct(ProductCreateDTO createDto)
    {
        var product = _mapper.Map<Product>(createDto);
        if (_productRepo.CreateProduct(product))
        {
            return Ok();
        }
        else
        {
            return BadRequest();
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<ProductReadDTO>> GetProducts()
    {
        var products = _productRepo.GetProducts();
        return Ok(_mapper.Map<IEnumerable<ProductReadDTO>>(products));
    }

    [HttpGet("{code}", Name = "GetByCode")]
    public ActionResult<ProductReadDTO> GetProduct(string code)
    {
        var product = _productRepo.GetProduct(code);
        if (product != null)
        {
            return Ok(_mapper.Map<ProductReadDTO>(product));
        }
        else
        {
            return NotFound();
        }
    }

    [HttpDelete]
    public ActionResult DeleteProduct(string code)
    {
        var product = _productRepo.GetProduct(code);
        if (product != null)
        {
            _productRepo.DeleteProduct(product);
            return Ok();
        }
        else {
            return NotFound();
        }
    }

    [HttpPut]
    public ActionResult UpdateProduct(ProductCreateDTO createDto)
    {
        var product = _mapper.Map<Product>(createDto);
        if (_productRepo.UpdateProduct(product))
        {
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}