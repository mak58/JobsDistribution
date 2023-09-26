namespace Distribuited.Services;

 public static class Logo
{
    public static void PrintLogo()
    {
        Console.Clear();
        string logo = @" 
             _____  _____  _________
            / ____||  __ \ |__  ___|
            | |    | |  \ |   | |
            | |___ | |__/ |   | |
            \_____||_____/    |_| 
         Company distribuition Titles ";

        Console.WriteLine(logo); 
        Console.WriteLine();   
    }
    
}
