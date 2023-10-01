/// Hello Guys! 2023-09-19 Tueday

public static class Program
{
    private static List<Job> jobs = new(DataSourceJobs.JobsTable());

    public static List<Job> Jobs { get => jobs; set => jobs = value; }

    public static void Main()
    {
        MenuApplication.Menu();
    }     
}

/// Created by Marcio_Koehler ₢2023