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
    
    public static void OrderingJob(int chosenService)
    {        
        Logo.PrintLogo();                

        var serviceId = UserInteraction
                        .GetServiceType(); 
        
        ServiceType? serviceKind = Program
                                  .ServiceTypes
                                  .FirstOrDefault(s => s.Id == serviceId.Item1); // Here I have the serviceType full properties.

        UserInteraction.PresentServices(serviceKind);

        var ListJobsCountMined = QueryService
                                .GetTitlesListByServiceTypeCode(serviceKind.Code);        
                                    
        var companyId = DistribuitingJob
                        .CreateJob(serviceKind, ListJobsCountMined);

        UserInteraction.IdJobResponseToUser(companyId);         

        JobRepository.AddJob(serviceKind.Code, companyId);

        ValueForwardingRepository.AddValueForwarding(companyId, serviceId.Item2, serviceKind.Code);         
    }  
}
