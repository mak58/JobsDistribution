/// Hello Guys! 2023-09-19 Tuesday

public static class Program
{
    #region // global variable Jobs list
        private static List<Job> jobs = new(DataSourceJobs.JobsTable());
        public static List<Job> Jobs { get => jobs; set => jobs = value; }
    #endregion

    #region // global variable Chages List
        private static List<Charge> charges = new(DataSourceCharges.ChargesTable()); 
        public static List<Charge> Charges { get => charges; set => charges = value; }    
    #endregion

    #region // global Variable Service Type list
        private static List<ServiceType> serviceTypes = new(DataSourceServiceTypes.ServiceTypesTable());
        public static List<ServiceType> ServiceTypes { get => serviceTypes; set => serviceTypes = value; }
    #endregion

    #region // global Variable ValueForwardings list
        private static List<ValueForwarding> valueForwardings = new(DataSourceForwardings.ForwardingTable());
        public static List<ValueForwarding> ValueForwardings { get => valueForwardings; set => valueForwardings = value; }
    #endregion

    public static void Main()
    {
        MenuApplication.Menu();
    }     
}

/// Created by Marcio_Koehler ₢2023