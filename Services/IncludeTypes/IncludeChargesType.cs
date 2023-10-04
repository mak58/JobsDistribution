
namespace Distribuited.Services.IncludeTypes;

public class IncludeChargesType
{
    public static void Include()
    {
        Logo.PrintLogo();                
        PrintIntoScreen.ConsoleWriteline("Cool! Let's to include a new Charge type.");

        var newCharge = GetChargeFromUser();

        // Update Charges DataSource
        GetUpdatedChargesList(newCharge);        
    }

    public static Charge GetChargeFromUser()
    {   
        var lastId = Program.Charges.Count + 1; // count chargeList + new charge id         

            PrintIntoScreen.ConsoleWriteline("Enter the Charge name description: ");
            var description = Console.ReadLine();

            PrintIntoScreen.ConsoleWriteline("Enter 'Y' if the Charge will be activated or 'N' will not: ");
            var active = char.Parse(Console.ReadLine().ToUpper()) == 'Y';

            PrintIntoScreen.ConsoleWriteline("Enter the Value of Charge: ");
            var chargeValue = decimal.Parse(Console.ReadLine());        

        // just for test, Remove it after Commit        
        System.Console.WriteLine($" Id ={lastId}, desc = {description}, Active = {active}, Value ={chargeValue}"); 

        return new Charge()
        {
            Id = lastId,
            Description = description,
            Active = active,
            CreatedAt = DateTime.Now,
            Value = chargeValue
        };
    }

    public static List<Charge> GetUpdatedChargesList(Charge charges)
    {
        Program.Charges.Add(charges);

        return Program.Charges;
    }                
    
}
