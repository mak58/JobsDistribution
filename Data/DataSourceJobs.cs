namespace Distribuited.Data;
public static class DataSourceJobs
{
    //DataSource/table that contains all jobs created.
    internal static List<Job> JobsTable() 
    {
        return new()
        {
            new Job {Id = 1, Code = "MLR", CreatedAt = new DateTime(2023,09,01), ValueForwardingId = 1, Company = 1},
            new Job {Id = 2, Code = "DA", CreatedAt = new DateTime(2023,09,05), ValueForwardingId = 2, Company = 1},
            new Job {Id = 3, Code = "RPN", CreatedAt = new DateTime(2023,09,10), ValueForwardingId = 3, Company = 1},
            new Job {Id = 4, Code = "MLR", CreatedAt = new DateTime(2023,09,15), ValueForwardingId = 1, Company = 2},            
        };
    }        
}
