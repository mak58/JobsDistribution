namespace Distribuited.Data;
public static class DataSourceJobs
{
    //DataSource/table that contains all jobs created.
    public static List<Job> JobsTable() 
    {
        return new()
        {
            new Job {Id = 1, Code = "MLR", CreatedAt = new DateTime(2023,09,01), Company = 1},
            new Job {Id = 2, Code = "DA", CreatedAt = new DateTime(2023,09,05), Company = 1},
            new Job {Id = 3, Code = "RPN", CreatedAt = new DateTime(2023,09,10), Company = 1},
            new Job {Id = 4, Code = "MLR", CreatedAt = new DateTime(2023,09,15), Company = 2},            
        };
    }        
}
