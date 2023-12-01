using Distribuited.Services.Querys;

namespace Distribuited.Repositories;

public class JobRepository
{
    /// <summary>
    /// Feeds the Job's List/Table.
    /// </summary>
    /// <param name="code"></param>
    /// <param name="companyId"></param>
    /// <returns> Result Ok/True</returns> <summary>
    public static bool AddJob(string code, int companyId)
    {        
        var job = new Job
        {
            Id = QueryJob.GetLastJobId() + 1,
            Code = code,            
            Company = companyId
        };

        Program.Jobs.Add(job);        
    
        return true; // SaveChanges() > 0;    
    }           
}
