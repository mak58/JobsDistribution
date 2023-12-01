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
                Charges = new[] {1,2}                  
            },

            new ServiceType
            {
                Id = 2, 
                Description = "Documento apostile", 
                Active = true,
                Code = "DA", 
                JobsCount = JobCount.Quantity,
                Charges = new[] {1,3}                 
            },

            new ServiceType
            {
                Id = 3,
                Description = "Rural promissory note",
                Active = true,
                Code = "RPN",
                JobsCount = JobCount.Amount,
                Charges = new[] {1,4}
            },

            new ServiceType
            {
                Id = 4,
                Description = "Inspection Service",
                Active = true,
                Code = "IS",
                JobsCount = JobCount.Replicated,
                Charges = new[] {1}
            }
        };       
    }
}
