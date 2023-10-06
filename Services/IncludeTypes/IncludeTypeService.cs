using Distribuited.Services.IncludeTypes;

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

        /// Show all Charges options available
        #region 
            var chargesDataSource = Program.Charges.Where(X => X.Active == true).ToList();                    
            
            foreach (var item in chargesDataSource)
                Console.WriteLine($"Id = {item.Id}, {item.Description}");
            var charges = Console.ReadLine().Split(' ', ',');         // here it takes the existent Charges

            PrintIntoScreen.ConsoleWriteline("Do you want to add a new change type? 'Y' or 'N' ? ");
            var hasNewCharge = char.Parse(Console.ReadLine().ToUpper()) == 'Y';

            var newCharge = new Charge();

            if (hasNewCharge)
            {
                // Calls new charge type input
                newCharge = IncludeChargesType.GetChargeFromUser();
                
                IncludeChargesType.GetUpdatedChargesList(newCharge);        
            }

            var chargesList = new int[charges.Length + 1];
            
            for (int i = 0; i < charges.Length; i++)        
                if (int.TryParse(charges[i], out int number))
                    chargesList[i] = number;

            chargesList[charges.Length] = newCharge.Id;                
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
        Program.ServiceTypesDataSource.Add(newServiceType);

        return Program.ServiceTypesDataSource;
    } 


        
}
