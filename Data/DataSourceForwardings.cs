namespace Distribuited.Data;

public static class DataSourceForwardings
{
    //DataSource/table that contains all Forwardings created.
    internal static List<ValueForwarding> ForwardingTable() 
    {
        return new()
        {
            new ValueForwarding { Id = 1, CreatedAt = new DateTime(2023,09,01), Charges = new[] {1,2} },
            new ValueForwarding { Id = 2, CreatedAt = new DateTime(2023,09,05), Charges = new[] {1,3} },
            new ValueForwarding { Id = 3, CreatedAt = new DateTime(2023,09,10), Charges = new[] {1,4} },
            new ValueForwarding { Id = 4, CreatedAt = new DateTime(2023,09,15), Charges = new[] {1,2} },
        };
    }    
}
