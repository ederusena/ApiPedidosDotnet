using ApiPedidosDotnet.Infra.Data;

namespace ApiPedidosDotnet.Endpoints.Categories;

public class CategoryPost
{
    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(CategoryRequest categoryRequest, ApplicationDBContext context)
    {
        return Results.Ok();
    }   
}
