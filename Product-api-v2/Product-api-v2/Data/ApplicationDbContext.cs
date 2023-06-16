using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using OrderingPlatform.Domain.Products;

namespace Product_api_v2.Data;

public class ApplicationDbContext : DbContext 
{
    public DbSet<Product>? Products { get; set; }

    public DbSet<Category>? Categories { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Ignore<Notification>();

        builder.Entity<Product>()
            .Property(p => p.Name).IsRequired();

        builder.Entity<Product>()
            .Property(p => p.Description).HasMaxLength(2000);

        builder.Entity<Product>()
            .Property(p => p.Price).HasColumnType("decimal(10,2)").IsRequired();

        builder.Entity<Category>()
            .Property(c => c.Name).IsRequired();

    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
    {
        configuration.Properties<String>().HaveMaxLength(100);
    }

}
