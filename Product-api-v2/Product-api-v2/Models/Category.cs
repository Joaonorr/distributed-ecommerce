using Flunt.Validations;

namespace Product_api_v2.Models;

public class Category : Entity
{
    public string Name { get; set; }

    public bool Active { get; set; }

    public Category() { }
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
