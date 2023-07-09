using Product_api_v2.Data;

namespace Product_api_v2.Endpoints;

public static class CategoryDelete
{
    public static string Template => "category/{id:guid}";
    public static string[] Method => new string[] { HttpMethod.Delete.ToString() };
    public static Delegate Handle => Action;

    public static async Task<IResult> Action(ApplicationDbContext context, Guid id)
    {

        if (id == Guid.Empty)
        {
            return Results.BadRequest("Id is required");
        }

        var category = context.Categories.FirstOrDefault(c => c.Id == id);

        if (category == null)
        {
            return Results.NotFound();
        }

        context.Categories.Remove(category);

        await context.SaveChangesAsync();

        return Results.Ok();
    }
}