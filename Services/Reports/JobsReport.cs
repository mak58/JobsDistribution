namespace Distribuited.Services;

public static class JobsReport
{
    public static void Report()
    {        
        Logo.PrintLogo();

        List<Title> listItems = DataSource.QueryJobsCount(); //Jobs List                                 
        
        PrintIntoScreen.ConsoleWriteline("--- Presenting jobs report -----");        

            foreach (var item in listItems)
                Console.WriteLine($"Company [{item.Id}] - Quantity jobs {item.Quantity} - Amount ${item.Amount}.");
        
        PrintIntoScreen.ConsoleWriteline("--- End of jobs report -----");                            
    }        
}
