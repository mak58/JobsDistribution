namespace Distribuited.Services.Querys;

public static class QueryService
{
    public static List<int> GetActiveCompanies()
    {
        return DataSourceCompanies.CompanyTable().Where(c => c.Active == true).Select(c => c.Id).ToList();
    }   

    public static List<Title> GetListTitleByCodeServiceType(string code)
    {
        var listActiveCompanies = QueryService.GetActiveCompanies();

        var listJobsCount = new List<Title>();
        
        for (int i = 0; i < listActiveCompanies.Count; i++)
        {                    
            // Joining tables Jobs and ValueForwardings
            var listJobsValues = from listJobs in Program.Jobs.ToList()
                                 join listValues in Program.ValueForwardings.ToList()
                                 on listJobs.Id equals listValues.JobId 
                                 where listJobs.Code == code
                                 where listJobs.Company == listActiveCompanies[i]
                                 orderby listJobs.Id                     
                                 select new 
                                 {
                                    listJobs.Id,
                                    listJobs.Code,
                                    listJobs.Company,
                                    listValues.TotalValue                          
                                 };

            var titleCounting = new Title() 
            { Id = listActiveCompanies[i], 
                Quantity = listJobsValues is not null ? listJobsValues.Count() : 0, 
                    Amount = listJobsValues is not null ? listJobsValues.Sum(x => x.TotalValue) : 0
            };    

            listJobsCount.Add(titleCounting);
        }
        
        foreach (var item in listJobsCount)        
            System.Console.WriteLine($"{item.Id},{item.Quantity}, {item.Amount}");

        return listJobsCount;
    }     
}
