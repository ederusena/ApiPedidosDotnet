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
