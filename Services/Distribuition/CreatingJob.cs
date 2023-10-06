using Distribuited.Services.Distribuition;
using Distribuited.Services.Querys;

namespace Distribuited.Services;

public static class CreatingJob
{        
    public static void InitiateJob(int chosenService)
    {        
        Logo.PrintLogo();
                            
        var serviceId = UserInteraction.GetServiceType();
        
        ServiceType? serviceKind = Program.ServiceTypesDataSource.FirstOrDefault(s => s.Id == serviceId);

        UserInteraction.PresentServices(serviceKind);

        var ListJobsCountMined = QueryService.GetTitlesListByServiceTypeCode(serviceKind.Code);        
                                    
        var companyId = DistribuitingJob.CreateJob(serviceKind, ListJobsCountMined);

        UserInteraction.IdJobResponseToUser(companyId); 

        // Next step: Create the job and Value Forwarding in the Data Source            
    }  

}
