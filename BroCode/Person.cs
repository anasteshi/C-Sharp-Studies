namespace BroCode;

public class Person
{
    public string Name;
    public int Age;
    public readonly List<Order> Orders = new();
    

    public static Person Introduce(string name, int age)
    {
        Console.WriteLine($"Hi, {name}! Im {age} years old.");
        return new Person();
    }
}