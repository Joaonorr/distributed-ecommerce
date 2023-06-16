using Microsoft.EntityFrameworkCore;
using Product_api_v2.Data;

namespace Product_api_v2.Endpoints.Product;

public static class ProductGetAll
{
    public static string Template => "/product";
    public static string[] Method => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static async Task<IResult> Action(ApplicationDbContext context)
    {
        var products = context.Products
            .Include(p => p.Name)
            .ToList();

        return Results.Ok(products);
    }
}
