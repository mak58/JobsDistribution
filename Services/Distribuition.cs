namespace Distribuited.Services;

public static class Distribuition
{
    /// <summary>
    /// This method receives a list of all services commited by Registry 
    /// and calculate which must to be the next Registry Office that will receive the job.
    /// </summary>
    /// <param name="listItems"></param>
    /// A list of quantity and amount of jobs requests on the  Registry Office.
    /// <param name="CountType"></param>
    /// The method to calculate the jobs distribuition
    /// <returns> Int that means the Registry Office number</returns> <summary>
    
    public static int CalculateDistribuite(List<Title> listItems, String CountType )
    {
        var registry = 0;
        var registryMax = 10000000M;
                
        for (int i = 0; i < listItems.Count; i++)
        {   
                if ((listItems[i].Quantity < registryMax) && (CountType.Contains("Quantity")))
                {
                    registryMax = listItems[i].Quantity;
                    registry = listItems[i].Id;                                 
                }            
                else                          
                    if ((listItems[i].Amount < registryMax) && (CountType.Contains("Amount")))                   
                    {
                        registryMax = listItems[i].Amount;      
                        registry = listItems[i].Id;             
                    }                                                                                  
        } 
        return registry;       
    }
}
