namespace Distribuited.Data;
public class DataSource
{
    internal static List<Title> QueryJobsCount()
    {
        return new()
        {
            new Title {Id = 1, Quantity = 1, Amount = 100M},
            new Title {Id = 2, Quantity = 3, Amount = 135.50M},
            new Title {Id = 3, Quantity = 4, Amount = 99.75M}
        };
    }  

    internal static ServiceType QueryServiceTypes()
    {
        return new ServiceType()
        {

            Id = 1,
            Description = "Music letter",
            Active = true,
            Charges =
                    new List<Charge>
                        {
                        new() {Id = 1, Description = "Registry", Value = 50.00M},
                        new() {Id = 2, Description = "Tax",Value = 5M}
                        }                  
        };
    }   
}
