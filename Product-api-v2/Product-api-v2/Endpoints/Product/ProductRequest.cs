using Product_api_v2.Models;

namespace Product_api_v2.Endpoints;

public class ProductRequest
{   
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid Category { get; set; }
    public decimal Price { get; set; }
    public int Stoock { get; set; }
    public bool Active { get; set; } = true;

}
