namespace Distribuited.Services;

public static class JobsDistribuitionVersionOne
{
    public static void CreateJob(List<ServiceType> _listServiceTypes, List<Title> _listItems, int serviceId, ServiceType serviceKind )
    {
        var companyId = Distribuition.CalculateDistribuite(_listItems, serviceKind.JobsCount); 

        CreateJob(companyId); 

        UpdateDataSource(_listServiceTypes, _listItems, companyId, serviceId); 
        
    }
        public static void CreateJob(int companyId)
        {                                    
            PrintIntoScreen.ConsoleWriteline(" --------------------------------------");
            PrintIntoScreen.ConsoleWriteline($"***[ Job by quantity send to Company #{companyId} ]***");
            PrintIntoScreen.ConsoleWriteline(" --------------------------------------");
            Thread.Sleep(2000);        
        }
        
        public static void UpdateDataSource(List<ServiceType> _listServiceTypes,
                                            List<Title> _listItems,
                                            int companyId,
                                            int serviceId)
        {            
            PrintIntoScreen.ConsoleWriteline("---- Updating Data Source ----");             

            ServiceType? serviceKind = _listServiceTypes.FirstOrDefault(s => s.Id == serviceId);       
            
            // var amount = 0M;
            // foreach (var item in serviceKind.Charges)
            //     amount += item.Value;
            
            // var index = _listItems.FindIndex(x => x.Id == companyId);
            // _listItems[index].Quantity ++;
            // _listItems[index].Amount += amount;

            // foreach (var item in _listItems)
            //     Console.WriteLine(item);
        }
            
}
