using Microsoft.AspNetCore.Mvc;
using Product_api_v2.Data;

namespace Product_api_v2.Endpoints;

public static class ProductDelete
{
    public static string Template => "product/{id:guid}";
    public static string[] Method => new string[] { HttpMethod.Delete.ToString() };
    public static Delegate Handle => Action;


    public static async Task<IResult> Action([FromRoute] Guid id, ApplicationDbContext context)
    {

        if (id == Guid.Empty)
        {
            return Results.BadRequest("Id is required");
        }

        var product = context.Products.FirstOrDefault(c => c.Id == id);

        if (product == null)
        {
            return Results.NotFound();
        }

        context.Products.Remove(product);

        await context.SaveChangesAsync();

        return Results.Ok();
    }
}