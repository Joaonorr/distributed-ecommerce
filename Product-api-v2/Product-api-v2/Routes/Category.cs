using Product_api_v2.Endpoints;

namespace Product_api_v2.Routes;

public static class Category
{
    public static void CategoryRoutes(this WebApplication app)
    {
        app.MapMethods(CategoryGetAll.Template, CategoryGetAll.Method, CategoryGetAll.Handle);

        app.MapMethods(CategoryPost.Template, CategoryPost.Method, CategoryPost.Handle);
    }
}
