using Distribuited.Services.Reports;

namespace Distribuited.Services;

public static class JobsReport
{
    public static void Report()
    {        
        Logo.PrintLogo();

        AskingToUserWhichReport();                                            
    }

    public static void AskingToUserWhichReport()
    {
        Dictionary<int, string> menuReportItems = new()
        {
            {0, "Back"},
            {1, "All Changes."},
            {2, "All ServiceTypes."},
            {3, "All Jobs."},
            {4, "Jobs by Code."},
            {5, "Jobs by Date."}
        };

        PrintIntoScreen.ConsoleWriteline("Great! But which report do you like to see?\n");
        
        foreach (var menuItem in menuReportItems)
            Console.WriteLine($"[{menuItem.Key}] - {menuItem.Value}");                            
        
        var optionMenu = int.Parse(Console.ReadLine());
    
            switch (optionMenu)
            {
                case 0 : MenuApplication.Menu(); break;

                case 1 : UserInteractionReport.AllChangesReport(); break;

                case 2 : UserInteractionReport.AllJobsReport(); break;

                case 3 : UserInteractionReport.AllJobsReport(); break;

                case 4 : UserInteractionReport.AllValueForwardings(); break;

                default: MenuApplication.Menu(); break;
            } 

            PrintIntoScreen.ConsoleWriteline("--- End of jobs report -----\n");
            Thread.Sleep(3000);                   
            AskingToUserWhichReport();
    } 

}
