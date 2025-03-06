namespace BroCode;

public class Person
{
    public string Name;
    public int Age;

    public static Person Introduce(string name)
    {
        Console.WriteLine($"Hi, {name}!");
        return new Person();
    }
}