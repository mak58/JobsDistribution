namespace Distribuited.Services.Reports;

public static class UserInteractionReport
{
    public static void AllJobsReport()
    {
        Logo.PrintLogo();        

        var allJobs = Program
                        .Jobs
                        .ToList();

        PrintIntoScreen.ConsoleWriteline("--- Presenting all jobs report -----\n"); 

        foreach (var job in allJobs)
            Console.WriteLine($"Job > #{job.Id}, ServiceType > {job.Code}, To Company > {job.Company}, Created at > {job.CreatedAt}");
    }      

    public static void AllChangesReport()
    {
        Logo.PrintLogo();

        var allChanges = Program
                        .Charges
                        .ToList();

        PrintIntoScreen.ConsoleWriteline("--- Presenting all changes report -----\n"); 

        foreach (var change in allChanges)
            Console.WriteLine($"Change > #{change.Id}, Description {change.Description}, Active {change.Active}, Values {change.Value}");
    }

    public static void AllServiceTypeReport()
    {
        Logo.PrintLogo();

        var allServiceTypes = Program
                              .ServiceTypes
                              .ToList();        

        PrintIntoScreen.ConsoleWriteline("--- Presenting all services types report -----\n"); 

        foreach (var types in allServiceTypes)
            Console.WriteLine($"Service Type > #{types.Id}, Description > {types.Description}, Active {types.Active}");
    }

    public static void AllValueForwardings()
    {
        Logo.PrintLogo();

        var allValues = Program
                        .ValueForwardings
                        .ToList();

        foreach (var values in allValues)
            Console.WriteLine($"Id > #{values.Id},  Charges > {values.Charges}, Values {values.TotalValue}");
    }

    public static void JobsByCode(string code)
    {
        Logo.PrintLogo();

        var jobsByCode = Program
                        .Jobs
                        .Where(x => x.Code == code)
                        .ToList();

        foreach (var job in jobsByCode)
            Console.WriteLine($"Job > #{job.Id}, ServiceType > {job.Code}, To Company > {job.Company}, Created at > {job.CreatedAt}");
    }
}
