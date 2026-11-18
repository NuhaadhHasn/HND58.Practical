using System.ComponentModel.DataAnnotations;
namespace ProductSales.API.Model;

public class Product
{
    [Key]
    public String Code { get; set; }
    [Required]
    public String Name { get; set; }
    [Required]
    public decimal Price { get; set; }
    public String Description { get; set; }
    [Required]
    public int Stock { get; set; }
    
    
}
