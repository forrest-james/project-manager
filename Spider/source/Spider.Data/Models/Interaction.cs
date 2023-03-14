namespace Spider.Data.Models;

internal class Interaction : AuditableEntity
{
    public Guid Id { get; set; }
    public required string Body { get; set; }
}