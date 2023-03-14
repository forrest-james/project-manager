namespace Spider.Data.Models;

internal class Ticket : AuditableEntity
{
    public Guid Id { get; set; }
    public required string TicketNumber { get; set; }
    public required string Subject { get; set; }
    public required string Description { get; set; }
    public Status Status { get; set; }
    public Contact? Contact { get; set; }
    public Account? Account { get; set; }
    public ICollection<Interaction> Interactions { get; set; }

    public Ticket()
    {
        Interactions = new HashSet<Interaction>();
    }
}