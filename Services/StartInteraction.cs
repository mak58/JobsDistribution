namespace Distribuited.Services;

public static class StartInteraction
{
    public static int ChoseOption(bool include = false, int serviceChosed = -1)
    {        
        Dictionary<int, string> menuItens = new()
        {
            { 1, "Jobs report." },
            { 2, "Create a job."},
            { 3, "Include a Service Type."},
            { 4, "Return to Menu"},
            { 5, "Exit."}
        };            

            if (include)
                Console.WriteLine("Hello! How can I help you today?");
            else
            {
                Console.WriteLine();
                Console.WriteLine("Let's go ahead! What else let's to do together right now?");                
            }
                            
            Console.WriteLine();
            Console.WriteLine("Chose one option and type...:");            
            Console.WriteLine();  

            menuItens.Remove(serviceChosed);                                 
            
            foreach (var item in menuItens)
                Console.WriteLine($"[{item.Key}] - {item.Value}");                            

            bool validNumber =  int.TryParse(Console.ReadLine(), out var number);
            
            return validNumber is true ? number : 0;        
    }   
}
