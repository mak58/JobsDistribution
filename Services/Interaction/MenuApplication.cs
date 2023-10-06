using Distribuited.Services.IncludeTypes;

namespace Distribuited.Services;

public static class MenuApplication
{
    public static void Menu()
    {
        Console.Clear();

        Logo.PrintLogo();        

        var chosenService = StartInteraction.ChoseOption(true);        

        while (chosenService < 6) 
        {
            switch (chosenService)
            {
                case 0: EndInteraction.Exit(); break;

                case 1: JobsReport.Report(); break;
                                                                            
                case 2: CreatingJob.InitiateJob(chosenService); break;

                case 3: IncludeServiceType.Include(); break;

                case 4: IncludeChargesType.Include(); break;

                case 5: JobsReport.ReportAllJobs(); break;

                default : EndInteraction.Exit(true);; break;
                
            }
            Thread.Sleep(3000);
            chosenService = StartInteraction.ChoseOption(false);        
        }
        
    }
        
}
