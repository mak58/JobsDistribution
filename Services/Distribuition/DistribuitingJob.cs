namespace Distribuited.Services;

public static class DistribuitingJob
{
    public static int CreateJob(ServiceType service, List<Title> ListJobsCountMined)
    {
        // Logo.PrintLogo();

        var companyId = service.JobsCount switch
        {   
            JobCount.Quantity or JobCount.Replicated
                 => DistribuitionCalculation
                                    .CalculateDistribuiteByQuatity(ListJobsCountMined),

            JobCount.Amount =>  DistribuitionCalculation
                                    .CalculateDistribuiteByAmount(ListJobsCountMined),            
            _ => 0
        };        

        return companyId;                                               
    }
}
