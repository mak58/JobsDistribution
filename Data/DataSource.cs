namespace Distribuited.Data;
public class DataSource
{
    internal static List<Title> QueryJobsCount() // V1 behavior
    {
        //TODO Create a select in method JobTable grouped by Company
        return new()
        {
            new Title {Id = 1, Quantity = 1, Amount = 55.00M},
            new Title {Id = 2, Quantity = 3, Amount = 255.00M},
            new Title {Id = 3, Quantity = 4, Amount = 418.00M}
        };
    }  

}
