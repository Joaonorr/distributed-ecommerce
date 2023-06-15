using Microsoft.EntityFrameworkCore;

namespace Product_api_v2.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


}
