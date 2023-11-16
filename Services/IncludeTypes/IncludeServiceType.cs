using Distribuited.Services.IncludeTypes;
using Distribuited.Services.Querys;

namespace Distribuited.Services;

public static class IncludeServiceType
{
    public static void Include()
    {
        Logo.PrintLogo();
        // PrintIntoScreen.ConsoleWriteline("Module not implemented yet! Hang a moment please.");

        PrintIntoScreen.ConsoleWriteline("Cool! Let's include a new Service type.");

        var newServiceType = GetDataFromUser();

        GetUpdatedServiceTypeList(newServiceType);
    }

    public static ServiceType GetDataFromUser()
    {                
        PrintIntoScreen.ConsoleWriteline("Enter the service name description: ");
        var description = Console.ReadLine();

        PrintIntoScreen.ConsoleWriteline("Enter 'Y' if the Service will be activated or 'N' will not: ");
        var active = char.Parse(Console.ReadLine().ToUpper()) == 'Y';

        PrintIntoScreen.ConsoleWriteline("Enter the code service Type containing only 3 letters: ");
        var code = Console.ReadLine().ToUpper();

        PrintIntoScreen.ConsoleWriteline("Enter 'Q' to count service by Quantity or 'A' by Amount: ");
        var countType = char.Parse(Console.ReadLine().ToUpper()) == 'Q' ? JobCount.Quantity : JobCount.Amount ;              

        PrintIntoScreen.ConsoleWriteline("Enter the number of charges for this type of service separated by a space:\n ");        
        
        #region /// Show all Charges options available
            var chargesDataSource = QueryChargeType.GetActiveCharges(true);                   
                            
            var chargesFromUser = Console.ReadLine().Split(' ', ','); // here it takes the existent Charges
        #endregion
                
            #region // Calls new charge type input 
                PrintIntoScreen.ConsoleWriteline("Do you want to add a new change type? 'Y' or 'N' ? ");
                var hasNewCharge = char.Parse(Console.ReadLine().ToUpper()) == 'Y';

                var newCharge = new Charge();

                if (hasNewCharge)
                {
                    newCharge = IncludeChargesType.GetChargeFromUser();
                    
                    IncludeChargesType.GetUpdatedChargesList(newCharge);        
                }

                var chargesList = new int[chargesFromUser.Length + 1];
                
                for (int i = 0; i < chargesFromUser.Length; i++)        
                    if (int.TryParse(chargesFromUser[i], out int number))
                        chargesList[i] = number;

                chargesList[chargesFromUser.Length] = newCharge.Id;                
            #endregion            

        return new ServiceType()
        {
            Id = newCharge.Id,
            Description = description,
            Active = active,
            CreatedAt = DateTime.Now, 
            Code = code,
            JobsCount = countType,
            Charges = chargesList
        };                
    }

    public static List<ServiceType> GetUpdatedServiceTypeList(ServiceType newServiceType)
    {
        Program.ServiceTypes.Add(newServiceType);

        return Program.ServiceTypes;
    } 


        
}
