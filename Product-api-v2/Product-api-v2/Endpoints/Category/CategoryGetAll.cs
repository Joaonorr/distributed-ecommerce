using Product_api_v2.Data;

namespace Product_api_v2.Endpoints;

public static class CategoryGetAll
{
    public static string Template => "/category";
    public static string[] Method => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static async Task<IResult> Action(ApplicationDbContext context)
    {
        var categories = context.Categories
            .OrderBy(c => c.Name)
            .ToList();

        return Results.Ok(categories);
    }
}
