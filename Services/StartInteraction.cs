namespace Distribuited.Services;

public static class StartInteraction
{
    public static int ChoseOption(bool include = false, int serviceChosed = -1)
    {        
        Dictionary<int, string> menuItens = new()
        {
            { 1, "Jobs report." },
            { 2, "Create a job."},
            { 3, "Exit."}
        };

            Console.WriteLine();

            if (include)
                Console.WriteLine("Hi! How can I help you today?");
            else
                Console.WriteLine("Let's go ahead! What else let's to do together right now?");
            
            Console.WriteLine();
            Console.WriteLine("Chose one option and type...:");            
            Console.WriteLine();  

            menuItens.Remove(serviceChosed);                                 
            
            foreach (var item in menuItens)
                Console.WriteLine($"[{item.Key}] - {item.Value}");                            

            return int.Parse(System.Console.ReadLine() ?? "0") ;                         
    }   
}
