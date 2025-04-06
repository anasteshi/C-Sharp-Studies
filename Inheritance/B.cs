namespace Inheritance;

class B:A
{
    public B()
    {
        Console.WriteLine(publicField);
        Console.WriteLine(_protectedField);
        // Console.WriteLine(_privateField); //it's private
    }

    public void PrintB()
    {
        Print();
    }
}