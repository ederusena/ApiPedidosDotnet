# ApiPedidosDotnet
---

## Criando dominio de categoria

> Dominio é o problema que deve ser resolvido

```md
Domain
├── Products
│   ├── Product.cs
│   └── Category.cs
│ 
Infra
├── Data
│   └── DBContext.cs
```

## Criando Class Product

```csharp
public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool HasStock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedAt { get; set; }
}
```

## Criando Class Category

```csharp
public class Category
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string CreateBy { get; set; }
	public DateTime CreatedAt { get; set; }
	public string EditedBy { get; set; }
	public DateTime EditedAt { get; set; }
}
```

## Refatorando as Classes de dominio, para herdar de BaseEntity

```csharp
public abstract class BaseEntity
{
    public BaseEntity()
    {
        Id = Guid.NewGuid();
        //CreatedAt = DateTime.Now;
        //EditedAt = DateTime.Now;
    }

    public Guid Id { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedAt { get; set; }
}
```

## Criando o Contexto DBContext

```csharp
using ApiPedidosDotnet.Domain.Products;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiPedidosDotnet.Infra.Data;

public class ApplicationDBContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
```

## Criando convernsões para o DBContext

```csharp
protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>()
            .HaveMaxLength(100);
    }
```

