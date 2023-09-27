namespace Distribuited.Services;

public static class MenuApplication
{
    public static void Menu()
    {
        Logo.PrintLogo();        

        var serviceChosed = StartInteraction.ChoseOption(true);
        var Continue = true;

        while (serviceChosed < 6) 
        {
            switch (serviceChosed)
            {
                case 0: EndInteraction.Exit(true); break;

                case 1: JobsReport.Report(); break;
                                                                            
                case 2: InitiateDistribuiton.InitiateJob(); break;

                case 3: IncludeTypeService.Include(); break;

                case 4: MenuApplication.Menu(); break;

                case 5: EndInteraction.Exit(); break;

                default : MenuApplication.Menu(); break;
            }

            // Call the jobs list without prior option chosed
            if (Continue)
            {
                Thread.Sleep(3000);
                var newServiceChose = StartInteraction.ChoseOption(false, serviceChosed);    
                serviceChosed = newServiceChose;            
            }               
        }
    }
        
}
