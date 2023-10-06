namespace Distribuited.Services;

public static class JobsReport
{
    public static void Report()
    {        
        Logo.PrintLogo();

        List<Title> listItems = DataSource.QueryJobsCount(); //Jobs List                                 
        
        PrintIntoScreen.ConsoleWriteline("--- Presenting jobs report -----\n");
        Thread.Sleep(300);        

            foreach (var item in listItems)
                Console.WriteLine($"Company [{item.Id}] - Quantity jobs {item.Quantity} - Amount ${item.Amount}.");
        
        PrintIntoScreen.ConsoleWriteline("--- End of jobs report -----");                            
    }  

    public static void ReportAllJobs()
    {
        Logo.PrintLogo();        

        var allJobs = Program.Jobs.ToList();

        PrintIntoScreen.ConsoleWriteline("--- Presenting all jobs report -----\n"); 

        foreach (var job in allJobs)
            System.Console.WriteLine($"Job > #{job.Id}, ServiceType > {job.Code}, To Company > {job.Company}, Created at > {job.CreatedAt}");
    }      
}
