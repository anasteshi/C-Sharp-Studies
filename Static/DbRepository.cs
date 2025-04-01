namespace Static;

public class DbRepository
{
    private static string connectionString;

    static DbRepository()
    {
        ConfigureManager cm = new ConfigureManager();
        connectionString = cm.GetConnectionString();
    }

    public void GetData()
    {
        Console.WriteLine("Using..." + connectionString);
    }
}