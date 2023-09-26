namespace Distribuited.Services;

public static class JobsReport
{
    public static void Report()
    {        
        Logo.PrintLogo();

        List<Title> listItems = DataSource.QueryJobsCount(); //Jobs List                                 
        
        Console.WriteLine("--- Presenting jobs report -----");
        Console.WriteLine();

            foreach (var item in listItems)
                Console.WriteLine($"Company [{item.Id}] - Quantity jobs {item.Quantity} - Amount {item.Amount}.");

        Console.WriteLine();
        Console.WriteLine("--- End of jobs report -----");                            
    }        
}
