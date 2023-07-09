using Flunt.Validations;

namespace Product_api_v2.Models;

public class Product : Entity
{
    public string Name { get; private set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public decimal Price { get; private set; }
    public int Stoock { get; set; }
    public bool Active { get; private set; } = true;

    public Product() { }

    public Product(string name, Category category, string description, decimal price, int Stoock, string createdBy)
    {
        this.Name = name;

        this.Category = category;

        this.CategoryId = category.Id;

        this.Description = description;

        this.Price = price;

        this.Stoock = Stoock;

        CreatedBy = createdBy;

        EditedBy = createdBy;

        Validate();
    }

    public void EditInfo(string name, string description , Category category, decimal price, int stoock, bool Active)
    {
        this.Name = name;

        this.Description = description;

        this.CategoryId = category.Id;

        this.Category = category;

        this.Price = price;

        this.Stoock = stoock;

        this.Active = Active;

        EditedOn = DateTime.Now.ToUniversalTime();

    }

    private void Validate()
    {
        var contract = new Contract<Product>()
            .IsNotNullOrEmpty(Name, "Name")
            .IsGreaterOrEqualsThan(Name, 3, "Name")
            .IsNotNullOrEmpty(Description, "Description")
            .IsGreaterOrEqualsThan(Description, 3, "Description")
            .IsNotNull(Category, "Category", "Category not found")
            .IsNotNullOrEmpty(CreatedBy, "CreatedBy")
            .IsNotNullOrEmpty(EditedBy, "EditedBy");
        AddNotifications(contract);
    }
}
