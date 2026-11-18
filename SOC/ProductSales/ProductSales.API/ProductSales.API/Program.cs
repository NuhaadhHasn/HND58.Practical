using Microsoft.EntityFrameworkCore;
using ProductSales.API.Data;
var builder = WebApplication.CreateBuilder(args);
var conn = @"Server=localhost;Database=58SOCNuhaadh;Trusted_Connection=True;TrustServerCertificate=Yes;";
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conn));
builder.Services.AddScoped<IProductRepo, ProductRepo>();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();