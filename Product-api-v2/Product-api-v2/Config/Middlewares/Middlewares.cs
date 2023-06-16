using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Data.SqlClient;

namespace Product_api_v2.Config.ConfigureMiddlewares;

public static class Middlewares
{
    public static void MiddlewaresConfig(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        //app.UseExceptionHandler("/error");
        //app.Map("/error", (HttpContext http) =>
        //{

        //    var error = http.Features?.Get<IExceptionHandlerFeature>()?.Error;

        //    if (error != null)
        //    {
        //        if (error is SqlException)
        //            return Results.Problem(title: "Database out", statusCode: 500);
        //        else if (error is BadHttpRequestException)
        //            return Results.Problem(title: "Error to convert data to other type. See all the information sent", statusCode: 500);
        //    }

        //    return Results.Problem(title: "An error ocurred", statusCode: 500);
        //});
    }
}
