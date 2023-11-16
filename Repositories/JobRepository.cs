using Distribuited.Services.Querys;

namespace Distribuited.Repositories;

public class JobRepository
{
    public static bool AddJob(string code, int companyId)
    {        
        var job = new Job()
        {
            Id = QueryJob.GetLastJobId() + 1,
            Code = code,            
            Company = companyId
        };

        Program.Jobs.Add(job);        
    
        return true; // SaveChanges() > 0;    
    }           
}
