using ProductSales.API.Model;

namespace ProductSales.API.Data;

public interface IProductRepo
{
    bool Save();

    Product GetProduct(String code);
    bool UpdateProduct(Product product);
    bool DeleteProduct(Product product);
    bool CreateProduct(Product product);
    IEnumerable<Product> GetProducts();

}