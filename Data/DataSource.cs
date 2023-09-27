namespace Distribuited.Data;
public class DataSource
{
    internal static List<Title> QueryJobsCount()
    {
        return new()
        {
            new Title {Id = 1, Quantity = 1, Amount = 55.00M},
            new Title {Id = 2, Quantity = 3, Amount = 255.00M},
            new Title {Id = 3, Quantity = 4, Amount = 418.00M}
        };
    }  

    internal static List<ServiceType> QueryServiceTypes()
    {
        return new()
        {
            new ServiceType
            {
            Id = 1, 
            Description = "Music letter registry", 
            Active = true, 
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
            JobsCount = JobCount.Quantity,
            Charges =
                    new List<Charge>
                        {
                           new() {Id = 1, Description = "Apostilamento", Value = 80.00M},
                           new() {Id = 2, Description = "Tax", Value = 5M}
                        }                  
            },

            new ServiceType
            {
            Id = 3,
            Description = "Rural promissory note",
            Active = true,
            JobsCount = JobCount.Amount,
            Charges =
                    new List<Charge>
                        {
                           new() {Id = 1, Description = "Registry", Value = 99.00M},
                           new() {Id = 2, Description = "Tax", Value = 5.50M}
                        }                  
            }
        };
    }   
}
