namespace Distribuited.Enums;

public enum JobCount
{
    Quantity = 1, // Job distributed to company that has fewer jobs
    Amount = 2,   // Job distributed to company that has lower value
    Replicated = 3  // One Job to each active company        
}
