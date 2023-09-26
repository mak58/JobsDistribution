namespace Distribuited.Services;

public static class EndInteraction
{   
    public static void Exit()
    {
        Console.WriteLine("Opsss, by by...");
        Console.WriteLine();
        Console.WriteLine("Warm regards! Have a nice day!");
        Console.WriteLine();
        // Console.ReadKey();
        Environment.Exit(0);
    }
        
}
