using Distribuited.Services.Querys;

namespace Distribuited.Services;

public static class JobsDistribuitionVersionTwo
{
    public static void CreateJob(ServiceType service)
    {
        Logo.PrintLogo();

        var ListJobsCountMined = QueryService.GetListTitleByCodeServiceType(service.Code);         

        var companyId = 0;
        switch (service.JobsCount)
        {   
            case JobCount.Quantity : 
            {
                companyId = Distribuition.CalculateDistribuiteByQuatity(ListJobsCountMined); 
                System.Console.WriteLine($"Job To company{companyId}");
                break;
            }
            case JobCount.Amount : companyId = Distribuition.CalculateDistribuiteByAmount(); break;
        }                                           
    }
}
