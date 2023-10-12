namespace Distribuited.Models;

public abstract class Entity
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public bool Active { get; set; } = true;
    public DateTime? CreatedAt { get; set; } = DateTime.Now;

}
