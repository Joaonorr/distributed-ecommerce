using Product_api_v2.Models;
using Product_api_v2.Data;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

namespace Product_api_v2.Endpoints;

public static class ProductPost
{
    public static string Template => "/product";
    public static string[] Method => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static async Task<IResult> Action(ProductRequest productRequest, ApplicationDbContext context)
    {

        if (productRequest.Category == Guid.Empty)
        {
            return Results.BadRequest("Category Id is required!");
        }

        var category = await context.Categories.FirstOrDefaultAsync(c => c.Id == productRequest.Category);

        if (category is null)
        {
            return Results.NotFound();
        }

        var product = new Product(
            productRequest.Name,
            category,
            productRequest.Description,
            productRequest.Price,
            productRequest.Stoock,
            ""
        );

        await context.Products.AddAsync(product);

        await context.SaveChangesAsync();

        return Results.Created($"{Template}/{category.Id}", category.Id);

    }
}
