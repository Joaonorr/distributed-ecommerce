using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Product_api_v2.Data;
using System.Security.Claims;

namespace Product_api_v2.Endpoints;

public class CategoryPut
{
    public static string Template => "category/{id:guid}";
    public static string[] Method => new string[] { HttpMethod.Put.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id, CategoryRequest categoryRequest, ApplicationDbContext context, HttpContext http)
    {

        if (categoryRequest.Name.IsNullOrEmpty())
        {
            return Results.BadRequest("Name is required");
        }

        var category = context.Categories.Where(c => c.Id == id).FirstOrDefault();

        if (category == null)
        {
            return Results.NotFound();
        }

        category.EditInfo(categoryRequest.Name, categoryRequest.Active, "");

        context.SaveChanges();

        return Results.Ok();
    }

}
