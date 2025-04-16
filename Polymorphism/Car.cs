namespace Polimorfizm;

public class Car
{
    protected virtual void StartEngine()
    {
        Console.WriteLine("Starting engine...");
    }
    public virtual void Drive()
    {
        StartEngine();
        Console.WriteLine("Driving a car...");
    }
}