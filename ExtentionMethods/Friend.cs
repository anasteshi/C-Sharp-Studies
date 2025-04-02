using Extention_methods_stalker;
namespace ExtentionMethods;

public class Friend
{
    private string name;
    public string Name { get; set; }
    
    private string _email;
    public string Email
    {
        private get
        {
            return _email;
        }
        set
        {
            _email = value;
        }
    }

    public uint Age { get; set; }

    private string _hobby { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hi, {Name}! Nice to meet you!");
    }

    public void AskForEmail()
    {
        Console.WriteLine($"{Name}, what's your email?");
        Email = Console.ReadLine();
        Email ??= "No email provided";
        Console.WriteLine("Oh, I see...");
    }

    public void AskForAge()
    {
        Console.WriteLine("What's your age?");
        Age = uint.Parse(Console.ReadLine());
        if (Age < 18)
            Console.WriteLine("Ohh, you're a baby :)");
        else
            Console.WriteLine($"Ah, so you're {Age}...that's cool. I'm 18 btw :)");
    }

    public void AskForHobby()
    {
        Console.WriteLine($"My dear, what's your hobby? :))");
        _hobby = Console.ReadLine();
        _hobby ??= "No hobby";
        Console.WriteLine("I see...How interesting.");
    }
    
    
}