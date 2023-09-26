namespace Distribuited.Services;

public static class MenuApplication
{
    public static void Menu()
    {
        Logo.PrintLogo();

        var serviceChosed = StartInteraction.ChoseOption(true);
        var Continue = true;

        while (serviceChosed < 3)
        {
            switch (serviceChosed)
            {
                case 1: JobsReport.Report(); break;
                                                                            
                case 2: InitiateDistribuiton.InitiateJob(); break;

                case 3: Continue = false; break;

                case 4: MenuApplication.Menu(); break;

                // case 5: 

                default : EndInteraction.Exit(); break;

            }

            // Call the jobs list without prior option chosed
            if (Continue)
            {
                var newServiceChose = StartInteraction.ChoseOption(false, serviceChosed);    
                serviceChosed = newServiceChose;            
            }               
        }
    }
        
}
