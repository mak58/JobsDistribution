namespace Distribuited.Models;

public class Job : Entity
{
    public string Code { get; set; } = "UKN"; //UNKNOWN       
    public ValueForwarding? Forwarding  { get; set; }
    public int Company { get; set; }
        
}
