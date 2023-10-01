namespace Distribuited.Services;

public static class EndInteraction
{   
    public static void Exit(bool except = false)
    {
        if (except)
            PrintIntoScreen.ConsoleWriteline("Option not found!");
        else
            PrintIntoScreen.ConsoleWriteline("Opsss....");
        
        PrintIntoScreen.ConsoleWriteline("Thanks to have you here! By by...");
        PrintIntoScreen.ConsoleWriteline("Warm regards! Have a nice day!\n");                                
        Environment.Exit(0);
    }
        
}
