using Distribuited.Services.Querys;
using Distribuited.Services.Reports;

namespace Distribuited.Repositories;

public class JobRepository
{
    public static bool AddJob(string code, int companyId)
    {        
        var job = new Job()
        {
            Id = QueryService.GetLastJobId() + 1,
            Code = code,            
            Company = companyId
        };

        Program.Jobs.Add(job);

        UserInteractionReport.JobsByCode(code); // It's only fot testing
    
        return true; // SaveChanges() > 0;    
    }           
}
