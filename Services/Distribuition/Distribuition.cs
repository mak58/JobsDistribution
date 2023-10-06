using System.Data.Common;
using System.Diagnostics.Contracts;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using Distribuited.Services.Querys;

namespace Distribuited.Services;

public static class Distribuition
{
    /// <summary>
    /// This method receives a list of all services commited by Company 
    /// and calculate which must to be the next Company that will receive the job.
    /// </summary>
    /// <param name="listItems"></param>
    /// A list of quantity and amount of jobs requests on the  Company.
    /// <param name="JobCount"></param>
    /// Enum type of two values to define the way to distribuite the job.
    /// <returns> Int that means the Company number</returns> <summary>
    
    public static int CalculateDistribuiteByQuatity(List<Title> titles)
    {        
        var company = 0;
        var valueMax = 10000000M;

        for (int i = 0; i < titles.Count; i++)
        {   
            if (titles[i].Quantity < valueMax)
            {
                valueMax = titles[i].Quantity;
                company = titles[i].Id;                                 
            } 
        }
        return company;                       
    }

    public static int CalculateDistribuiteByAmount()
    {
        var company = 0;
        var valueMax = 10000000M;

        
        var groupItems = Program.Jobs.GroupBy(x => x.Company);
        var listItems = new List<Title>();

        foreach (var item in groupItems)
            System.Console.WriteLine(item);
                
        for (int i = 0; i < listItems.Count; i++)
        {                             
            if (listItems[i].Amount < valueMax)                  
            {
                valueMax = listItems[i].Amount;      
                company = listItems[i].Id;             
            }                                                                                  
        } 
        return company;       
    }


}
