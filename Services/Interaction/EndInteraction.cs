namespace Distribuited.Services;

public static class EndInteraction
{   
    public static void Exit(bool except = false)
    {
        if (except)
            Console.WriteLine("Option not found!");
        else
            Console.WriteLine("Opsss....");
        
        PrintIntoScreen.ConsoleWriteline("Warm regards! Have a nice day!");
        Console.WriteLine("Thanks to have you here! By by...");                
        Console.WriteLine();        
        Environment.Exit(0);
    }
        
}
