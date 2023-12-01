using Distribuited.Services.Querys;

namespace Distribuited.Repositories;

public class ValueForwardingRepository
{
    public static bool AddValueForwarding(int companyId, int[] charges, string code)
    {   
                
        var valueForwarding = new ValueForwarding
        {   
            Id = QueryValueForwarding.GetLastValueForwardingId() + 1,
            JobId = companyId,
            Charges = charges,
            TotalValue = QueryChargeType.GetAmountByListCharges(charges) //QueryService.GetChangesListByServiceTypeCode(code)
        };

         Program.ValueForwardings.Add(valueForwarding);

         return true; /// SaveChanges() > 0
    }       
}