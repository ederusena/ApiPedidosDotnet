namespace ApiPedidosDotnet.Domain.Products;

public class Product : BaseEntity
{
    public string Description { get; set; }
    public bool HasStock { get; set; }
    public int CategoryId { get; set; } // Falar que é uma chave estrangeira obrigatória
    public Category Category { get; set; }
}
