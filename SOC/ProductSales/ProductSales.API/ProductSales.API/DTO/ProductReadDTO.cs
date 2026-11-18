namespace ProductSales.API.DTO;

public class ProductReadDTO
{
    public String Code { get; set; }
    public String Name { get; set; }
    public decimal Price { get; set; }
    public String Description { get; set; }
}