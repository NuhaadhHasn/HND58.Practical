using Microsoft.EntityFrameworkCore;
using ProductSales.API.Model;

namespace ProductSales.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");
        // Do the same for all the models
        // modelBuilder.Entity<Customer<();

        modelBuilder.Entity<Customer>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var conn = @"Server=localhost;Database=58SOCNuhaadh;Trusted_Connection=True;TrustServerCertificate=Yes;";
        optionsBuilder.UseSqlServer(conn);
    }
}