namespace Inheritance;

public class Dog : Wolf
{
    public Dog(string name, int age) : base(name, age)
    {
        
    }
    
    public void Bark()
    {
        Console.WriteLine("Bark! Bark!");
    }
}