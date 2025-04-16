namespace Polimorfizm;

public class SportCar:Car
{
    protected override void StartEngine()
    {
        Console.WriteLine("Starting sport car engine...");
    }

    public override void Drive()
    {
        StartEngine();
        Console.WriteLine("Driving a sport car...");
    }
}