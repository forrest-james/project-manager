using Spider.Data.ValueObjects;

namespace Spider.Data.Models;

internal class Account : AuditableEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }

    public required Address Address { get; set; }
    public bool IsActive { get; set; }

    public ICollection<Contact> Contacts { get; set; }
    public ICollection<Ticket> Tickets { get; set; }


    public Account()
    {
        Contacts = new HashSet<Contact>();
        Tickets = new HashSet<Ticket>();
    }
}