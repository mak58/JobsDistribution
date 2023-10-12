namespace Distribuited.Services.Querys;

public static class QueryService
{
    public static List<int> GetActiveCompanies() =>
        DataSourceCompanies
        .CompanyTable()
        .Where(c => c.Active == true)
        .Select(c => c.Id)
        .ToList();
    
    public static List<int> GetIdActiveChanges() =>
        DataSourceCharges
        .ChargesTable()
        .Where(c => c.Active == true)
        .Select(c => c.Id)
        .ToList();

    public static List<Charge> GetActiveCharges(bool print = false)
    {
        var activeCharges = Program
                            .Charges
                            .Where(X => X.Active == true)
                            .ToList();        

        if(print)
            foreach (var item in activeCharges)
                Console.WriteLine($"Id = {item.Id}, {item.Description}");

        return activeCharges;
    }

    public static int GetLastJobId() =>
        Program.Jobs.Count > 0 
            ? Program.Jobs.Last().Id 
            : 0;        

    public static int GetLastChargeId() =>
        Program
        .Charges
        .Last()
        .Id;

    public static int GetLastValueForwardingId() =>
        Program.ValueForwardings.Count > 0
            ? Program.ValueForwardings.Last().Id
            : 0;
    
    public static List<Title> GetTitlesListByServiceTypeCode(string code)
    {
        var listActiveCompanies = QueryService.GetActiveCompanies();

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
            { Id = listActiveCompanies[i], 
                Quantity = listJobsValues is not null ? listJobsValues.Count : 0, 
                    Amount = listJobsValues is not null ? listJobsValues.Sum(x => x.TotalValue) : 0
            };   

        System.Console.WriteLine(listJobsValues.Count);
        
        foreach (var item in listJobsValues)
        {
            System.Console.WriteLine($" {item.Id}- {item.Code} - {item.Company} - {item.TotalValue}");
            Thread.Sleep(300);
        }
        Thread.Sleep(9000);
            listJobsCount.Add(titleCounting);
        }
        
        #region // It's just for test
            foreach (var item in listJobsCount)        
                Console.WriteLine($"Code= {code}, Id= {item.Id},Quantity= {item.Quantity}, Amount= {item.Amount}");
            Thread.Sleep(2000);
        #endregion

        return listJobsCount;
    }   

    public static decimal GetChangesListByServiceTypeCode(string code)
    {           
        // Method in stand by...
        var charges = from service in Program.ServiceTypes.ToList()
                      from Charge in service.Charges
                      join charge in Program.Charges
                      on Charge equals charge.Id
                      where service.Code == code
                      select new
                      {                        
                        charge.Value                        
                      };

        var sumCharges = 0M;
        foreach (var item in charges)
            sumCharges += item.Value;        
        
        return sumCharges;
    }
}
