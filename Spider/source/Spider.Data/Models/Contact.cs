using Spider.Data.ValueObjects;

namespace Spider.Data.Models;

internal class Contact
{
    public Guid Id { get; set; }
    public required Name Name { get; set; }
    public required string EmailAddress { get; set; }
    public string? PhoneNumber { get; set; }
    public Address? Address { get; set; }
    public required Account Account { get; set; }
    public bool IsActive { get; set; }
    public ICollection<Ticket> Tickets { get; set; }

    public Contact()
    {
        Tickets = new HashSet<Ticket>();
    }
}