namespace ApiPedidosDotnet.Domain.Products;

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
