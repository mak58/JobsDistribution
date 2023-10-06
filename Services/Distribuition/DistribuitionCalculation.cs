namespace Distribuited.Services;

public static class DistribuitionCalculation
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

    public static int CalculateDistribuiteByAmount(List<Title> titles)
    {
        var company = 0;
        var valueMax = 10000000M;
                
        for (int i = 0; i < titles.Count; i++)
        {                             
            if (titles[i].Amount < valueMax)                  
            {
                valueMax = titles[i].Amount;      
                company = titles[i].Id;             
            }                                                                                  
        } 
        return company;       
    }


}
