namespace Distribuited.Models;

public class ServiceType : Entity
{
    public string Code { get; set; } = "UKN"; //UNKNOWN
    public JobCount JobsCount { get; set; }
    public int[]? Charges { get; set; } = null;
}
