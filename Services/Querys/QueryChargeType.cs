namespace Distribuited.Services.Querys;

public static class QueryChargeType
{    
    public static List<int> GetIdActiveCharges() =>
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

    public static int GetLastChargeId() =>
        Program
        .Charges
        .Last()
        .Id;
}
