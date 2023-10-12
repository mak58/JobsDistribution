using Distribuited.Services.Querys;

namespace Distribuited.Services;

public static class DistribuitingJob
{
    public static int CreateJob(ServiceType service, List<Title> ListJobsCountMined)
    {
        Logo.PrintLogo();                 

        var companyId = 0;
        switch (service.JobsCount)
        {   
            case JobCount.Quantity : companyId = DistribuitionCalculation
                                                .CalculateDistribuiteByQuatity(ListJobsCountMined); break;

            case JobCount.Amount : companyId = DistribuitionCalculation
                                               .CalculateDistribuiteByAmount(ListJobsCountMined); break;            
        }  
        return companyId;                                                 
    }
}
