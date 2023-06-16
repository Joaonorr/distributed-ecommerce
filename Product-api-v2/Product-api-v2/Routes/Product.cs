using Product_api_v2.Endpoints.Product;

namespace Product_api_v2.Routes;

public static class Product
{
    public static void ProductRoutes(this WebApplication app)
    {
        app.MapMethods(ProductGetAll.Template, ProductGetAll.Method, ProductGetAll.Handle);
    }
}
