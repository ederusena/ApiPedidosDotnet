﻿namespace ApiPedidosDotnet.Domain.Products;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedAt { get; set; }
}
