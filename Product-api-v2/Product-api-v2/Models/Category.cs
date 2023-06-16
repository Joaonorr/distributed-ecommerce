﻿using Flunt.Validations;

namespace OrderingPlatform.Domain.Products;

public class Category : Entity
{
    public string Name { get; private set; }

    public bool Active { get; private set; }

    public Category(string name, string createdBy, string editedBy)
    {
        Name = name;

        Active = true;

        CreatedBy = createdBy;

        EditedBy = editedBy;

        validate();
    }

    public void EditInfo(string name, bool active, string editedBy)
    {
        Name = name;

        Active = active;

        EditedBy = editedBy;

        EditedOn = DateTime.Now;

        validate();
    }

    private void validate()
    {
        var contract = new Contract<Category>()
                    .IsNotNullOrEmpty(Name, "Name")
                    .IsGreaterOrEqualsThan(Name, 3, "Name")
                    .IsNotNullOrEmpty(CreatedBy, "CreatedBy")
                    .IsNotNullOrEmpty(EditedBy, "EditedBy");
        AddNotifications(contract);
    }
}
