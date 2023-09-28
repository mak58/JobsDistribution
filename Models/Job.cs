namespace Distribuited.Models;

public class Job : Entity
{
    public string Code { get; set; } = "UKN"; //UNKNOWN   
    public int ValueForwardingId { get; set; }
    public ValueForwarding? Forwarding  { get; set; }
    public int Company { get; set; }
        
}
