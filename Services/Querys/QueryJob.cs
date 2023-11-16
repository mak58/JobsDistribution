namespace Distribuited.Services.Querys;

public static class QueryJob
{
    public static int GetJobCount()
     => Program
        .Jobs
        .Count;

    public static int GetLastJobId() =>
        Program.Jobs.Count > 0 
            ? Program.Jobs.Last().Id 
            : 0;
}
