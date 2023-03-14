using Spider.Data.Enums;

namespace Spider.Data.Models;

internal class Status
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public StatusStage Stage { get; set; }
    public bool IsActive { get; set; }
}