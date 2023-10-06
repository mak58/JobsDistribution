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

        foreach (var services in Program.ServiceTypesDataSource)
            Console.WriteLine($"Id [{services.Id}] - Service: {services.Description}");            

        PrintIntoScreen.ConsoleWriteline("Id [0] - Back");

        return int.Parse(Console.ReadLine() ?? string.Empty);        
    }  

    public static void PresentServices(ServiceType serviceKind)
    {
        Logo.PrintLogo();

        if (serviceKind is not null)
            PrintIntoScreen.ConsoleWriteline($"Job: [{serviceKind.Id}] - {serviceKind.Description}");
        else
            MenuApplication.Menu();
        
        Thread.Sleep(1500);
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
        Thread.Sleep(2000);        
    }        
}
