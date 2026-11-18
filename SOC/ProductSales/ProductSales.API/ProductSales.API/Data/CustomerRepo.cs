using ProductSales.API.Model;

namespace ProductSales.API.Data;

public class CustomerRepo:ICustomerRepo
{
    private AppDbContext _dbContext;
    
    public CustomerRepo(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public bool Save()
    {
        int count = _dbContext.SaveChanges();
        if (count > 0)
            return true;
        else
            return false;
    }

    public Customer GetCustomer(int id)
    {
        return _dbContext.Customers.FirstOrDefault(customer => customer.Id == id);

    }

    public bool UpdateCustomer(Customer customer)
    {
        if (customer != null)
        {
            _dbContext.Customers.Update(customer);
            return Save();
        }
        else
        {
            return false;
        }
    }

    public bool DeleteCustomer(Customer customer)
    {
        if (customer != null)
        {
            _dbContext.Customers.Remove(customer);
            return Save();
        }
        else
        {
            return false;
        }
    }

    public bool CreateCustomer(Customer customer)
    {
        if (customer != null)
        {
            _dbContext.Customers.Add(customer);
            return Save();
        }
        else
        {
            return false;
        }
    }

    public IEnumerable<Customer> GetCustomer()
    {
        return _dbContext.Customers.ToList();
    }
}