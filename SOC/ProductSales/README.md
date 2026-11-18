# ProductSales

A two-part class assignment. The two projects work together.

```
ProductSales.Forms  (WinForms client)  --HTTP-->  ProductSales.API  (Web API)  -->  SQL Server
```

## ProductSales.API

An ASP.NET Core Web API on **.NET 7**, using Entity Framework Core 7 with SQL Server,
AutoMapper for DTO mapping, a repository pattern, and Swagger for trying the endpoints.

| Method | Route | What it does |
| --- | --- | --- |
| `POST` | `/api/Product` | Create a product |
| `GET` | `/api/Product` | List all products |
| `GET` | `/api/Product/{code}` | Get one product by code |
| `PUT` | `/api/Product` | Update a product |
| `DELETE` | `/api/Product?code=...` | Delete a product |

A product has a `Code`, `Name`, `Price`, `Description` and `Stock`. The project also
has a `Customer` model and repository, but they are not exposed by a controller yet.

### Database

The connection string is hardcoded in `Program.cs` and `Data/AppDBContext.cs`:

```
Server=localhost;Database=58SOCNuhaadh;Trusted_Connection=True;TrustServerCertificate=Yes;
```

It uses Windows authentication against a local SQL Server, so there is no password in
the code. Change the server or database name there if yours differ. Create the tables
from the included EF Core migrations:

```bash
cd ProductSales.API/ProductSales.API
dotnet ef database update
```

## ProductSales.Forms

A WinForms form (**.NET Framework 4.7.2**) for managing products. It has fields for
Code, Name, Price, Description and Stock, and buttons to **Add, Update, Edit, Delete,
Find and Reload**. Every action is an HTTP call to the API at
`http://localhost:5236/api/Product`.

## Running both

1. Make sure SQL Server is running and the migrations have been applied.
2. Start **ProductSales.API** with the `http` launch profile, which listens on port
   `5236`. Swagger opens at `http://localhost:5236/swagger`.
3. Start **ProductSales.Forms**. Start the API first, because the form calls it.
