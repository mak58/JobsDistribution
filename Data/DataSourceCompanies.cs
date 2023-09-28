namespace Distribuited.Data;
public static class DataSourceCompanies
{
    //DataSource/table that contains all Companies created.
    internal static List<Company> CompanyTable() 
    {
        return new()
        {
            new Company() { Id = 1, Description = "Dell Tech", CreatedAt = new DateTime(1989,01,01), Active = true},
            new Company() { Id = 2, Description = "HP Laptops", CreatedAt = new DateTime(1991,06,01), Active = true},
            new Company() { Id = 3, Description = "Asus Ltda", CreatedAt = new DateTime(1992,06,26), Active = false},
            new Company() { Id = 4, Description = "Apple Company", CreatedAt = new DateTime(1996,11,10), Active = true}
        };
    }  
}
