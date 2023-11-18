# ApiPedidosDotnet
---

## Criando dominio de categoria

> Dominio é o problema que deve ser resolvido

```md
Domain
├── Products
│   ├── Product.cs
│   └── Category.cs
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
