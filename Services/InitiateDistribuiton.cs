using Distribuited.Models;

namespace Distribuited.Services;

public static class InitiateDistribuiton
{
    public static void InitiateJob()
    {        
        Logo.PrintLogo();

        Console.WriteLine();
        Console.WriteLine("Chose an option to create a job!");
        
        List<ServiceType> serviceTypes = DataSource.QueryServiceTypes(); // Service types List containing the Changes
                    
        var serviceId = InitiateDistribuiton.PresentServices(serviceTypes);

        ServiceType? serviceKind = serviceTypes.FirstOrDefault(s => s.Id == serviceId);

        GetServiceType(serviceKind);

        CreateJob(serviceKind);                
    }    

    public static int PresentServices(List<ServiceType> serviceTypes)
    {
        Logo.PrintLogo();

        Console.WriteLine("Please, Choose a type of service do you want to create!");
        Console.WriteLine();        
        Console.WriteLine("[Service Types]");
        Console.WriteLine();

        foreach (var services in serviceTypes)
            Console.WriteLine($"Id [{services.Id}] - Service: {services.Description}");            

        return int.Parse(Console.ReadLine() ?? "0");        
    }     

    public static void GetServiceType(ServiceType serviceKind)
    {
        Logo.PrintLogo();

        if (serviceKind is not null)
            Console.WriteLine($"{serviceKind.Id} - {serviceKind.Description}");
        else
            MenuApplication.Menu();

        Console.WriteLine();
        Console.WriteLine("* ...... Creating a new job .... *");
        Console.WriteLine();
        Console.WriteLine("* ..... Wait a second please ....*");                
    }

    public static void CreateJob(ServiceType serviceKind)
    {
        // Logo.PrintLogo();

        List<Title> listItems = DataSource.QueryJobsCount();

        var company = Distribuition.CalculateDistribuite(listItems, serviceKind.JobsCount); 

        Console.WriteLine();
        Console.WriteLine(" --------------------------------------");
        Console.WriteLine($"***[ Job by quantity send to Company #{company}]***");
        Console.WriteLine(" --------------------------------------");
    }
}
