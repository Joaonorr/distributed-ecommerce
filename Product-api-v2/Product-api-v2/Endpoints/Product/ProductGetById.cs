using Microsoft.AspNetCore.Mvc;
using Product_api_v2.Data;

namespace Product_api_v2.Endpoints;

public static class ProductGetById
{
    public static string Template => "product/{id:guid}";
    public static string[] Method => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id, ApplicationDbContext context)
    {
        if (id == Guid.Empty)
        {
            return Results.BadRequest("Id is required");
        }

        var product = context.Products.Where(p => p.Id == id).FirstOrDefault();

        if (product == null)
        {
            return Results.NotFound();
        }

        return Results.Ok(product);
    }
}
