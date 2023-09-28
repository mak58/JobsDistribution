namespace Distribuited.Data;
public static class DataSourceCharges
{
    //DataSource/table that contains all Charges created.
    internal static List<Charge> ChargesTable() 
    {
        return new()
        {
            new Charge {Id = 1, Description = "Tax", Value = 5M},
            new Charge {Id = 2, Description = "Registry", Value = 50.00M},            
            new Charge {Id = 3, Description = "Apostilament", Value = 60.00M},
            new Charge {Id = 4, Description = "RuralRegistry", Value = 80.00M},
        };
    }   
}
