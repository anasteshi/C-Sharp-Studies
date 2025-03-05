namespace BroCode;

public class Car
{
    private String model;
    private String color;

    public Car(String model, String color)
    {
        this.model = model;
        this.color = color;
    }

    public static void StartRace()
    {
        Console.WriteLine("The race has begun!");
    }
    
}