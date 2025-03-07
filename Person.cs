namespace BroCode;

public class Person
{
    public string Name;
    public int Age;
    public List<Order> Orders;

    public Person()
    {
        Orders = new List<Order>();
    }
    public Person(string name)
    : this()
    {
        this.Name = name;
    }

    public Person(string name, int age)
    :this(name)
    {
        this.Name = name;
        this.Age = age;
    }

    public static Person Introduce(string name, int age)
    {
        Console.WriteLine($"Hi, {name}! Im {age} years old.");
        return new Person();
    }
}