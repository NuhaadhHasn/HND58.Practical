using System.ComponentModel.DataAnnotations;
namespace ProductSales.API.DTO;

public class CustomerCreateDTO
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
}