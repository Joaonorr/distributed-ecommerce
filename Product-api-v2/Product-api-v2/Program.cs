using Product_api_v2.Config.ConfigureMiddlewares;
using Product_api_v2.Config.ConfigureServices;
using Product_api_v2.Routes;

var builder = WebApplication.CreateBuilder(args);

builder.ServiceConfig();

var app = builder.Build();

app.MiddlewaresConfig();

app.CategoryRoutes();

app.ProductRoutes();

app.Run();