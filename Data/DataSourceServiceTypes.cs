namespace Distribuited.Data;
public static class DataSourceServiceTypes
{
    //DataSource/table that contains all ServiceTyps including owns default Chases created.
    internal static List<ServiceType> ServiceTypesTable() 
    {
        return new()
        {
            new ServiceType
            {
            Id = 1, 
            Description = "Music letter registry", 
            Active = true,
            Code = "MLR",
            JobsCount = JobCount.Quantity,
            Charges =
                    new List<Charge>
                        {
                           new() {Id = 1, Description = "Registry", Value = 50.00M},
                           new() {Id = 2, Description = "Tax", Value = 5M}
                        }                  
            },

            new ServiceType
            {
            Id = 2, 
            Description = "Documento apostile", 
            Active = true,
            Code = "DA", 
            JobsCount = JobCount.Quantity,
            Charges =
                    new List<Charge>
                        {
                           new() {Id = 1, Description = "Apostilament", Value = 60.00M},
                           new() {Id = 2, Description = "Tax", Value = 5M}
                        }                  
            },

            new ServiceType
            {
            Id = 3,
            Description = "Rural promissory note",
            Active = true,
            Code = "RPN",
            JobsCount = JobCount.Amount,
            Charges =
                    new List<Charge>
                        {
                           new() {Id = 1, Description = "Rural Registry", Value = 99.00M},
                           new() {Id = 2, Description = "Tax", Value = 5.50M}
                        }                  
            }
        };
    }   
}
