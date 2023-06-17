using Flunt.Notifications;

namespace Product_api_v2.Models;

public abstract class Entity : Notifiable<Notification>
{
    public Guid Id { get; set; }
    public string? CreatedBy { get; set; }
    public string? EditedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime EditedOn { get; set; }

    public Entity()
    {
        Id = Guid.NewGuid();

        DateTime dateTime = DateTime.Now.ToUniversalTime();

        CreatedOn = dateTime;

        EditedOn = dateTime;
    }

}
