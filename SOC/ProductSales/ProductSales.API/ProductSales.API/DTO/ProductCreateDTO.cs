using System.ComponentModel.DataAnnotations;
namespace ProductSales.API.DTO;

public class ProductCreateDTO
{
    [Required]
    public String Code { get; set; }
    [Required]
    public String Name { get; set; }
    [Required]
    public decimal Price { get; set; }
    public String Description { get; set; }
}