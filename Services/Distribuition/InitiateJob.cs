using System.Security.Cryptography.X509Certificates;
using Distribuited.Repositories;
using Distribuited.Services.Distribuition;
using Distribuited.Services.Querys;

namespace Distribuited.Services;

public static class InitiateJob
{        
    /// <summary>
    /// This method calls all other methods that perform calculation, mining, user interaction and job distribution.
    /// </summary>
    /// <param name="chosenService"></param> <summary>
    /// This parameter receives the option chosen by the user in the application menu.
    /// </summary>
    
    public static void CreatingANewJob()
    {
        Logo.PrintLogo();

        var serviceId = UserInteraction
                        .GetServiceType();

        _ = OrderingJob(serviceId); 
    }
    public static bool OrderingJob(int serviceId, bool test = false)
    {                  
        var charges = UserInteraction
                        .GetChargesType(serviceId, test);              
        
        ServiceType? serviceKind = Program
                                  .ServiceTypes
                                  .FirstOrDefault(s => s.Id == serviceId); // Here I have the serviceType full properties.

        if(!test)
            UserInteraction.PresentServices(serviceKind);

        var ListJobsCountMined = QueryService
                                .GetTitlesListByServiceTypeCode(serviceKind.Code);        
                                    
        var companyId = DistribuitingJob
                        .CreateJob(serviceKind, ListJobsCountMined);
        if(!test)
            UserInteraction.IdJobResponseToUser(companyId);         

        JobRepository.AddJob(serviceKind.Code, companyId);

        ValueForwardingRepository.AddValueForwarding(companyId, charges, serviceKind.Code);

        return true;
    }  
}
