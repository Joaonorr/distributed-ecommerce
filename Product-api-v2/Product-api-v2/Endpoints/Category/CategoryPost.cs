using Product_api_v2.Models;
using Product_api_v2.Data;
using Microsoft.IdentityModel.Tokens;

namespace Product_api_v2.Endpoints;

public static class CategoryPost
{
    public static string Template => "/category";
    public static string[] Method => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static async Task<IResult> Action(CategoryRequest categoryRequest, ApplicationDbContext context)
    {

        if (categoryRequest.Name.IsNullOrEmpty())
        {
            return Results.BadRequest("Name is required");
        }
        
        var category = new Category(categoryRequest.Name, "", "");

        await context.Categories.AddAsync(category);

        await context.SaveChangesAsync();

        return Results.Created($"{Template}/{category.Id}", category.Id);

    }
}
