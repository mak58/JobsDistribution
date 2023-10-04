namespace Distribuited.Data;
public static class DataSourceCharges
{
    //DataSource/table that contains all Charges created.
    internal static List<Charge> ChargesTable() 
    {
        return new()
        {
            new Charge {Id = 1, Description = "Tax", Active = true, CreatedAt = new DateTime(2023,01,01), Value = 5M},
            new Charge {Id = 2, Description = "Registry", Active = true, CreatedAt = new DateTime(2023,01,01), Value = 50.00M},            
            new Charge {Id = 3, Description = "Apostilament", Active = false, CreatedAt = new DateTime(2023,01,01), Value = 60.00M},
            new Charge {Id = 4, Description = "RuralRegistry", Active = true, CreatedAt = new DateTime(2023,01,01), Value = 80.00M},
        };
    }   
}