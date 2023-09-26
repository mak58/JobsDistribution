namespace Distribuited.Services;

public static class EndInteraction
{   
    public static void Exit(bool except = false)
    {
        if (except)
            Console.WriteLine("Option not found! By...");
        else
            Console.WriteLine("Opsss....");

        Console.WriteLine();
        Console.WriteLine("Warm regards! Have a nice day!");
        Console.WriteLine("Thanks to have you here!  by by...");                
        Console.WriteLine();        
        Environment.Exit(0);
    }
        
}
