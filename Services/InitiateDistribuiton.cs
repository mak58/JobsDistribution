using Distribuited.Models;

namespace Distribuited.Services;

public static class InitiateDistribuiton
{
    private static readonly List<Title> _listItems = new(DataSource.QueryJobsCount());
    private static readonly List<ServiceType> _listServiceTypes = new(DataSource.QueryServiceTypes());
    
    public static void InitiateJob()
    {        
        Logo.PrintLogo();

        Console.WriteLine();
        Console.WriteLine("Choose an option to create a job!");
                    
        var serviceId = InitiateDistribuiton.PresentServices();

        ServiceType? serviceKind = _listServiceTypes.FirstOrDefault(s => s.Id == serviceId);

        GetServiceType(serviceKind);

        var companyId = Distribuition.CalculateDistribuite(_listItems, serviceKind.JobsCount); 

        CreateJob(companyId); 

        UpdateDataSource(companyId, serviceId);               
    }    

    public static int PresentServices()
    {
        Logo.PrintLogo();

        Console.WriteLine("Please, Choose a type of service do you want to create!");
        Console.WriteLine();        
        Console.WriteLine("[Service Types]");
        Console.WriteLine();

        foreach (var services in _listServiceTypes)
            Console.WriteLine($"Id [{services.Id}] - Service: {services.Description}");            

        return int.Parse(Console.ReadLine() ?? string.Empty);        
    }     

    public static void GetServiceType(ServiceType serviceKind)
    {
        Logo.PrintLogo();

        if (serviceKind is not null)
            Console.WriteLine($"Job: [{serviceKind.Id}] - {serviceKind.Description}");
        else
            MenuApplication.Menu();

        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine("* ...... Creating a new job .... *");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine("* ..... Wait a second please ....*");                
        Thread.Sleep(2000);
    }

    public static void CreateJob(int companyId)
    {                        
        Console.WriteLine();
        Console.WriteLine(" --------------------------------------");
        Console.WriteLine($"***[ Job by quantity send to Company #{companyId} ]***");
        Console.WriteLine(" --------------------------------------");        
    }

    public static void UpdateDataSource(int companyId, int serviceId)
    {
        Console.WriteLine();
        Console.WriteLine("---- Updating Data Source ----");
        Console.WriteLine(); 

        ServiceType? serviceKind = _listServiceTypes.FirstOrDefault(s => s.Id == serviceId);       
        
        var amount = 0M;
        foreach (var item in serviceKind.Charges)
            amount += item.Value;
        
        var index = _listItems.FindIndex(x => x.Id == companyId);
        _listItems[index].Quantity ++;
        _listItems[index].Amount += amount;

        foreach (var item in _listItems)
            System.Console.WriteLine(item);
    }
}
