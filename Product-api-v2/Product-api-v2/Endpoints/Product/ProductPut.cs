using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Product_api_v2.Data;
using System.Security.Claims;

namespace Product_api_v2.Endpoints;

public class ProductPut
{
    public static string Template => "product/{id:guid}";
    public static string[] Method => new string[] { HttpMethod.Put.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id, ProductRequest productRequest, ApplicationDbContext context, HttpContext http)
    {

        if (productRequest.Name.IsNullOrEmpty())
        {
            return Results.BadRequest("Name is required");
        }

        var product = context.Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            return Results.NotFound();
        }

        var category = context.Categories.FirstOrDefault(c => c.Id == product.CategoryId);

        if (category == null)
        {
            return Results.NotFound("This product not have Category");
        }

        product.EditInfo(
            productRequest.Name,
            productRequest.Description,
            category,
            productRequest.Price,
            productRequest.Stoock,
            productRequest.Active
            );

        context.SaveChanges();

        return Results.Ok();
    }

}
