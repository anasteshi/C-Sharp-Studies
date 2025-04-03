namespace Inheritance;

public class Cat: Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }
    
    public void Meow()
    {
        Console.WriteLine("Meow! Meow!");
    }

    public void Purr()
    {
        Console.WriteLine("Purr...purr...");
    }
    
}