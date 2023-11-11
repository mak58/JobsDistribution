using Distribuited.Services.Querys;

namespace Distribuited.Repositories;

public class ValueForwardingRepository
{
    public static bool AddValueForwarding(int companyId, object charges, string code)
    {    
        var valueForwarding = new ValueForwarding()
        {   
            Id = QueryService.GetLastValueForwardingId() + 1,
            JobId = companyId,
            Charges = charges as int[],
            TotalValue = QueryService.GetChangesListByServiceTypeCode(code)
        };

         Program.ValueForwardings.Add(valueForwarding);

         return true; /// SaveChanges() > 0
    }       
}