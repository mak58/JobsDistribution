namespace Distribuited.Services;

public static class InitiateDistribuiton
{
    private static readonly List<Title> _listItems = new(DataSource.QueryJobsCount());
    private static readonly List<ServiceType> _listServiceTypes = new(DataSourceServiceTypes.ServiceTypesTable());
    
    public static void InitiateJob(int chosenService)
    {        
        Logo.PrintLogo();

        PrintIntoScreen.ConsoleWriteline("Choose an option to create a job!");
                    
        var serviceId = InitiateDistribuiton.PresentServices();
        
        ServiceType? serviceKind = Program.ServiceTypesDataSource.FirstOrDefault(s => s.Id == serviceId);

        GetServiceType(serviceKind);        
    
        switch (chosenService)
        {
            case 2 : JobsDistribuitionVersionOne.CreateJob(_listServiceTypes, _listItems, serviceId, serviceKind); break;
            
            case 5 : JobsDistribuitionVersionTwo.CreateJob(serviceKind); break;
        }        
    }  

    public static int PresentServices()
    {
        Logo.PrintLogo();

        PrintIntoScreen.ConsoleWriteline("Please, Choose a type of service do you want to create!");
        
        PrintIntoScreen.ConsoleWriteline("[Service Types]\n");        

        foreach (var services in Program.ServiceTypesDataSource)
            Console.WriteLine($"Id [{services.Id}] - Service: {services.Description}");            

        PrintIntoScreen.ConsoleWriteline("Id [0] - Back");

        return int.Parse(Console.ReadLine() ?? string.Empty);        
    }  

    public static void GetServiceType(ServiceType serviceKind)
    {
        Logo.PrintLogo();

        if (serviceKind is not null)
            PrintIntoScreen.ConsoleWriteline($"Job: [{serviceKind.Id}] - {serviceKind.Description}");
        else
            MenuApplication.Menu();
        
        Thread.Sleep(2000);
        PrintIntoScreen.ConsoleWriteline("* ...... Creating a new job .... *");
        
        Thread.Sleep(2000);
        PrintIntoScreen.ConsoleWriteline("* ..... Wait a second please ....*");                

        Thread.Sleep(2000);
    }

        //Analyse and relocated these methods. If not used, so remove it
        public static void CreateJob(int companyId)
        {                                    
            PrintIntoScreen.ConsoleWriteline(" --------------------------------------");
            PrintIntoScreen.ConsoleWriteline($"***[ Job by quantity send to Company #{companyId} ]***");
            PrintIntoScreen.ConsoleWriteline(" --------------------------------------");
            Thread.Sleep(2000);        
        }
        
        public static void UpdateDataSource(List<ServiceType> _listServiceTypes,
                                            List<Title> _listItems,
                                            int companyId,
                                            int serviceId)
        {            
            PrintIntoScreen.ConsoleWriteline("---- Updating Data Source ----");             

            ServiceType? serviceKind = _listServiceTypes.FirstOrDefault(s => s.Id == serviceId);                   
        }
}
