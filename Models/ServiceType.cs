namespace Distribuited.Models;

public class ServiceType : Entity
{
    public string Code { get; set; } = "UKN"; //UNKNOWN
    public JobCount JobsCount { get; set; }
    public List<Charge>? Charges { get; set; }
}
