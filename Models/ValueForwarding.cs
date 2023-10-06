namespace Distribuited.Models;

public class ValueForwarding : Entity
{    
    public int JobId { get; set; }
    public int[]? Charges { get; set; }
    public decimal TotalValue { get; set; }       
}
