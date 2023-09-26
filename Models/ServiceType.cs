namespace Distribuited.Models;

public class ServiceType : Entity
{
    public JobCount JobsCount { get; set; }
    public List<Charge>? Charges { get; set; }
}
