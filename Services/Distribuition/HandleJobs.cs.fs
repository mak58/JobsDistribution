using Distribuited.Repositories;
using Distribuited.Services.Distribuition;
using Distribuited.Services.Querys;

namespace Distribuited.Services;

public static class HandleJobs
{        
    /// <summary>
    /// This method calls all other methods that perform calculation, mining, user interaction and job distribution.
    /// </summary>
    /// <param name="chosenService"></param> <summary>
    /// This parameter receives the option chosen by the user in the application menu.
    /// </summary>
    
    public static async void CreatingANewJob()
    {
        Logo.PrintLogo();

        var serviceId = UserInteraction
                        .GetServiceType();

        _ = await OrderingJob(serviceId); 
    }
    public static async Task<bool> OrderingJob(int serviceId, bool test = false)
    {                                
        ServiceType? serviceKind = Program
                                  .ServiceTypes
                                  .FirstOrDefault(s => s.Id == serviceId); // Here I have the serviceType full properties.

        if(!test)
            UserInteraction.PresentServices(serviceKind);

        var companyId = await AddJob(serviceKind);

        if(!test)
            UserInteraction.IdJobResponseToUser(companyId);                                                 

        await AddValueForwardling(serviceId, companyId, serviceKind, test);

        return true;
    }

    public static async Task<int> AddJob(ServiceType serviceKind)
    {

        var listJobsCountMined = QueryService
                                .GetTitlesListByServiceTypeCode(serviceKind.Code);
        
        var companyId = DistribuitingJob
                        .CreateJob(serviceKind, listJobsCountMined);                

        JobRepository.AddJob(serviceKind.Code, companyId); // Add the primary service

        if(serviceKind.JobsCount == JobCount.Replicated) // Add the seconday services
        {
            //Todo insert of others jobs
            var companiesActives = QueryService.GetActiveCompanies();
            companiesActives.Remove(companyId);

            for (int i = 0; i < companiesActives.Count; i++)
                JobRepository.AddJob(serviceKind.Code, companiesActives[i]);

        }                

        return companyId;
    }  

    public static async Task AddValueForwardling(int serviceId, 
                                                 int companyId,
                                                 ServiceType serviceKind,
                                                 bool test)  
    {    
        var charges = UserInteraction
                        .GetChargesType(serviceId, test);

        ValueForwardingRepository.AddValueForwarding(companyId, charges, serviceKind.Code);                        

    }
}
