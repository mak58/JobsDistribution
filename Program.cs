Console.Clear();

Console.WriteLine("");
Console.WriteLine("Hello, World!");
Console.WriteLine("");

//Jobs List
List<Title> listItems = DataSource.QueryJobsCount();

// Service types List containing the Changes
ServiceType serviceTypes = DataSource.QueryServiceTypes();

Console.WriteLine("----Job including-----");
Console.WriteLine($"[Job Id] #{serviceTypes.Id}, [Job type description:] {serviceTypes.Description}");
foreach (var item in serviceTypes.Charges)    
    Console.WriteLine($"Charges: Id #{item.Id}, Service Job: {item.Description}, Chases: {item.Value}");

Console.WriteLine("");
Console.WriteLine("--- Data Source -----");
foreach (var item in listItems)
    System.Console.WriteLine($"Registry #{item.Id}, Quantity jobs {item.Quantity}, Amount {item.Amount}.");

Console.WriteLine("");
Console.WriteLine("* Sending job by quantity for Registry... *");
Console.WriteLine("* Wait a second please... *");

Console.WriteLine("");
// It calls the method that calculate about jobs quantity.
var registry = Distribuition.CalculateDistribuite(listItems, "Quantity");

Console.WriteLine($"Job by quatity send to Registry #{registry}");
Console.WriteLine("");

var amount = 0M;
foreach (var item in serviceTypes.Charges)
{ 
    amount += item.Value;
}

// Update the Jobs List
var index = listItems.FindIndex(x => x.Id == registry);
listItems[index].Quantity += registry;
listItems[index].Amount += amount;

// print the jobs list updated
Console.WriteLine("----Updating Data Source----");
Console.WriteLine("");
foreach (var item in listItems) 
    Console.WriteLine(item.ToString());

// Here the program is calling the method that count by Amount
Console.WriteLine("");
Console.WriteLine($"Job by Amount to Registry {Distribuition.CalculateDistribuite(listItems, "Average")}");
