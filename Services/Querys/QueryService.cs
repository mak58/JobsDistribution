namespace Distribuited.Services.Querys;

public static class QueryService
{
    public static List<int> GetActiveCompanies() =>
        DataSourceCompanies
        .CompanyTable()
        .Where(c => c.Active == true)
        .Select(c => c.Id)
        .ToList();


    /// <summary>
    /// This method make a list joining Jobs and ValueForwardigs
    /// The list group all companies contanining quantity anda amount 
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>

    public static List<Title> GetTitlesListByServiceTypeCode(string code)
    {
        var listActiveCompanies = GetActiveCompanies();

        var listJobsCount = new List<Title>();
        
        for (int i = 0; i < listActiveCompanies.Count; i++)
        {              
            // Join between Jobs and ValueFOrwardings tables.      
            var listJobsValues = Program.Jobs
                                .Join(Program.ValueForwardings,
                                 job => job.Company,
                                 value => value.JobId,
                                 (job, value) => new   
                                {
                                    job.Id,
                                    job.Code,
                                    job.Company,
                                    value.JobId,
                                    value.TotalValue                                                                                                       
                                })                                                                
                                .Where(x => x.Code == code)
                                .Where(x => x.Company == listActiveCompanies[i])                                                                                               
                                .ToList();
                            
            var titleCounting = new Title() 
            {   Id = listActiveCompanies[i], 
                Quantity = listJobsValues is not null ? listJobsValues.Count : 0, 
                Amount = listJobsValues is not null ? listJobsValues.Sum(x => x.TotalValue) : 0
            };   

        Console.WriteLine(listJobsValues.Count);
        
        foreach (var item in listJobsValues)        
            Console.WriteLine($" {item.Id}- {item.Code} - {item.Company} - {item.TotalValue}");        
        
            listJobsCount.Add(titleCounting);
        }
        
        #region // It's just for test
            foreach (var item in listJobsCount)        
                Console.WriteLine($"Code= {code}, Id= {item.Id},Quantity= {item.Quantity}, Amount= {item.Amount}");
            // Thread.Sleep(2000);
        #endregion

        return listJobsCount;
    }   

    /// <summary>
    ///  Summing values from ServiceType through join to Charges Table
    /// </summary>
    /// <param name="code"></param>
    /// Type code parameter 
    /// <returns>
    /// sum decimal value calcuated
    /// </returns>

    public static decimal GetChangesListByServiceTypeCode(string code)
    {           
        
        var charges = from service in Program.ServiceTypes.ToList()     // group all serviceTypes 
                      from Charge in service.Charges                    // group only array charges in service charges
                      join charge in Program.Charges                    // Join Charges ids from ServiceTypes to ChargesTable
                      on Charge equals charge.Id                        // matching the code from ServiceTypes to ChargesTable code 
                      where service.Code == code                        // codes are equals
                      select new { charge.Value };

        var sumCharges = 0M;
        foreach (var item in charges)
            sumCharges += item.Value;        
        
        return sumCharges;
    }
}
