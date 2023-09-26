namespace Distribuited.Services;

public static class Distribuition
{
    /// <summary>
    /// This method receives a list of all services commited by Company 
    /// and calculate which must to be the next Company that will receive the job.
    /// </summary>
    /// <param name="listItems"></param>
    /// A list of quantity and amount of jobs requests on the  Company.
    /// <param name="CountType"></param>
    /// The method to calculate the jobs distribuition
    /// <returns> Int that means the Company number</returns> <summary>
    
    public static int CalculateDistribuite(List<Title> listItems, JobCount JobCount )
    {
        var Company = 0;
        var valueMax = 10000000M;
                
        for (int i = 0; i < listItems.Count; i++)
        {   
                if ((listItems[i].Quantity < valueMax) && (JobCount == JobCount.Quantity))
                {
                    valueMax = listItems[i].Quantity;
                    Company = listItems[i].Id;                                 
                }            
                else                          
                    if ((listItems[i].Amount < valueMax) && (JobCount == JobCount.Amount))                   
                    {
                        valueMax = listItems[i].Amount;      
                        Company = listItems[i].Id;             
                    }                                                                                  
        } 
        return Company;       
    }
}
