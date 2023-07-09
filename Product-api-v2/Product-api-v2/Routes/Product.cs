using Product_api_v2.Endpoints;

namespace Product_api_v2.Routes;

public static class Product
{
    public static void ProductRoutes(this WebApplication app)
    {
        app.MapMethods(ProductGetAll.Template, ProductGetAll.Method, ProductGetAll.Handle);

        app.MapMethods(ProductGetById.Template, ProductGetById.Method, ProductGetById.Handle);

        app.MapMethods(ProductPost.Template, ProductPost.Method, ProductPost.Handle);

        app.MapMethods(ProductPut.Template, ProductPut.Method, ProductPut.Handle);

        app.MapMethods(ProductDelete.Template, ProductDelete.Method, ProductDelete.Handle);
    }
}
