
namespace Distribuited.Services;

public static class StartInteraction
{
    public static int ChoseOption(bool include = false, int serviceChosed = -1)
    {        
        Dictionary<int, string> menuItens = new()
        {
            { 0, "Exit."},
            { 1, "Jobs report." },
            { 2, "Create a job."},
            { 3, "Include a Service Type."},
            { 4, "Include a Charge Type"},
            { 5, "..."}            
        };            

            if (include)
                PrintIntoScreen.ConsoleWriteline("Hello! How can I help you today?");
            else
                PrintIntoScreen.ConsoleWriteline("Let's go ahead! What else let's to do together right now?");

            Thread.Sleep(300);
                                
            PrintIntoScreen.ConsoleWriteline("Chose one option and type...:\n");                        
            Thread.Sleep(300);                                             
            
            foreach (var item in menuItens)
                Console.WriteLine($"[{item.Key}] - {item.Value}");                            

            bool validNumber =  int.TryParse(Console.ReadLine(), out var number);
            
            return validNumber is true ? number : 0;        
    }   
}
