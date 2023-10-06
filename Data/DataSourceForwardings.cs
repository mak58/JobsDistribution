namespace Distribuited.Data;

public static class DataSourceForwardings
{
    //DataSource/table that contains all Forwardings created.
    internal static List<ValueForwarding> ForwardingTable() 
    {
        return new()
        {
            new ValueForwarding { Id = 1, CreatedAt = new DateTime(2023,09,01), JobId = 1, Charges = new[] {1,2}, TotalValue = 55.00M},
            new ValueForwarding { Id = 2, CreatedAt = new DateTime(2023,09,05), JobId = 2, Charges = new[] {1,3}, TotalValue = 65.00M},
            new ValueForwarding { Id = 3, CreatedAt = new DateTime(2023,09,10), JobId = 3, Charges = new[] {1,4}, TotalValue = 85.00M },
            new ValueForwarding { Id = 4, CreatedAt = new DateTime(2023,09,15), JobId = 4, Charges = new[] {1,2}, TotalValue = 55.00M },
        };
    }    
}
