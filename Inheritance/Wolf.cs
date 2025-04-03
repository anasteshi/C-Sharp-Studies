namespace Inheritance;

public class Wolf : Animal
{
    public Wolf(string name, int age) : base(name, age)
    {
        
    }
    
    public void Howl()
    {
        Console.WriteLine("Awoooooo...");
    }
}