namespace Distribuited.Services.Interaction;

public static class PrintIntoScreen
{
    public static void ConsoleWriteline(string message)
    {        
        Console.WriteLine($"\n{message}");
    }        
}
