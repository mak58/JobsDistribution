using Distribuited.Services.Querys;

namespace Distribuited.Services.Distribuition;

public class UserInteraction
{
    public static int GetServiceType()
    {
        Logo.PrintLogo();

        PrintIntoScreen.ConsoleWriteline("Ok! Let's go!");
        Thread.Sleep(1000);

        PrintIntoScreen.ConsoleWriteline("Please, Choose a type of service do you want to create!");
        
        PrintIntoScreen.ConsoleWriteline("[Service Types]\n");                        

        foreach (var services in Program.ServiceTypes)
            Console.WriteLine($"Id [{services.Id}] - Service: {services.Description}");                        

        PrintIntoScreen.ConsoleWriteline("Id [0] - Back");

        var idService = int.Parse(Console.ReadLine() ?? string.Empty);
                
        return idService;        
    }  

    public static int[] GetChargesType(int idService, bool test)
    {
        bool useDefaultCharges;

        if(test)
            useDefaultCharges = true;
        else
        {
            PrintIntoScreen.ConsoleWriteline("Would you like to add default Charges? 'Y' or 'No'.");
            useDefaultCharges = char.Parse(Console.ReadLine().ToUpper()) == 'Y';
        }

        int[]? chargesDefault = null; // Actually I don't know if this is a good practice LOL
        string[]? newCharges = null;

        if (useDefaultCharges) 
        {
            chargesDefault = Program
                            .ServiceTypes[idService]
                            .Charges
                            .ToArray();
        }           
        else
        {
            PrintIntoScreen.ConsoleWriteline("Choose the Charges you want to use.");
            // var activeCharges = QueryChargeType.GetActiveCharges(true); 
            newCharges = Console.ReadLine().Split(' ');
        }

        for (int i = 0; i < newCharges.Length; i++)
            chargesDefault[i] = int.Parse(newCharges[i]);
                        
        return chargesDefault;
    }

    public static void PresentServices(ServiceType serviceKind)
    {
        Logo.PrintLogo();

        if (serviceKind is not null)
            PrintIntoScreen.ConsoleWriteline($"Job: [{serviceKind.Id}] - {serviceKind.Description}");
        else
            MenuApplication.Menu();
        
        Thread.Sleep(1000);
        PrintIntoScreen.ConsoleWriteline("* ...... Creating a new job .... *");
        
        Thread.Sleep(1000);
        PrintIntoScreen.ConsoleWriteline("* ..... Wait a second please ....*");                

        Thread.Sleep(1000);
    }        
    public static void IdJobResponseToUser(int companyId)
    {                                    
        PrintIntoScreen.ConsoleWriteline(" --------------------------------------");
        PrintIntoScreen.ConsoleWriteline($"***[ Job by quantity send to Company #{companyId} ]***");
        PrintIntoScreen.ConsoleWriteline(" --------------------------------------");
        PrintIntoScreen.ConsoleWriteline("---- Updating Data Source ----");
        Thread.Sleep(1000);        
    }        
}
