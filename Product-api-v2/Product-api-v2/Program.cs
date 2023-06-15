using Product_api_v2.Services;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/", () =>
{
    return "Hello World!";
});

app.Run();