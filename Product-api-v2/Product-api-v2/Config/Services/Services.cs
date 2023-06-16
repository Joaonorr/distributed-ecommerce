using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Product_api_v2.Data;

namespace Product_api_v2.Config.ConfigureServices;

/**
 * <summary>
 * Classe estática que contém métodos para configuração de serviços.
 * </summary>
 **/
public static class Services
{
    public static void ServiceConfig(this WebApplicationBuilder builder)
    {
        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        //builder.Services.AddCors();

        var pgsqlConnection = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

        if (pgsqlConnection == null)
        {
            pgsqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
        }

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseNpgsql(pgsqlConnection));

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseNpgsql(pgsqlConnection);

        using (var dbContext = new ApplicationDbContext(optionsBuilder.Options))
        {
            try
            {
                dbContext.Database.OpenConnection();
                Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha na conexão com o banco de dados: {ex.Message}");
            }
            finally
            {
                dbContext.Database.CloseConnection();
            }
        }

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            options.UseNpgsql(configuration.GetConnectionString(pgsqlConnection));
        });


    }
}
