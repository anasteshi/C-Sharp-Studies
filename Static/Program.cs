namespace Static;

class ClassTest
{
    public ClassTest()
    {
        // counter++;
        Counter++;
    }
    private static int counter;

    public static int Counter
    {
        get => counter;
        private set => counter = value;
    }
    
    public int CounterIndividual
    {
        get => counter;
        private set => counter = value;
    }

    public static int GetCounter()
    {
        return counter;
    }
    public int GetCounterIndividually()
    {
        return counter;
    }
    
}
class StaticClass
{
    private static int a;
    private int b;
    public static int c { get; set; }
    public static int d;

    public static int D
    {
        get { return d; }
        set { d = value; }
    }

    public static void Foo()
    {
        Console.WriteLine("Foo method!");
        //cannot work with non-static fields/methods in static method
        a = 10;
        Console.WriteLine(a);
    }

    public void Bar()
    {
        Console.WriteLine("Bar method!");
        //but CAN with static ones
        b = 11;
        a = 12;
        Console.WriteLine($"{a} + {b}");
        Foo();
    }
}
class Program
{
    static void Main(string[] args)
    {
        ClassTest a = new ClassTest();
        Console.WriteLine(a.GetCounterIndividually());
        ClassTest b = new ClassTest();
        Console.WriteLine(b.CounterIndividual); //property
        ClassTest c = new ClassTest();
        Console.WriteLine(c.CounterIndividual);
        Console.WriteLine(ClassTest.Counter); //static property
        //need to make Counter Property setter private or remove
        //because it's possible to do this, if we don't:
        // ClassTest.Counter = -100000;
        //made for encapsulation
        Console.WriteLine(ClassTest.GetCounter());
    }
}