namespace Inheritance;

class A
{
    public int publicField;
    private int _privateField;
    // private protected int _protectedField;
    protected int _protectedField = 5;

    public A()
    {
        Console.WriteLine("publicField = " + publicField); //ok
        Console.WriteLine("_privateField = " + _privateField); //ok
        Console.WriteLine("_protectedField = " + _protectedField); //ok
    }

    public void Print()
    {
        Console.WriteLine("publicField = " + publicField); //ok
        Console.WriteLine("_privateField = " + _privateField); //ok
        Console.WriteLine("_protectedField = " + _protectedField); //ok
    }

}