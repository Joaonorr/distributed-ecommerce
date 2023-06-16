﻿using Flunt.Validations;

namespace OrderingPlatform.Domain.Products;

public class Product : Entity
{
    public string Name { get; private set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public decimal Price { get; private set; }
    public bool HasStoock { get; set; }
    public bool Active { get; private set; } = true;

    public Product() { }

    public Product(string name, Category category, string description, decimal price, bool hasStoock, string createdBy)
    {
        Name = name;
        Category = category;
        Description = description;
        Price = price;
        HasStoock = hasStoock;

        CreatedBy = createdBy;
        EditedBy = createdBy;

        Validate();
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
