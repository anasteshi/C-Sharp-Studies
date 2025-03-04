namespace BroCode;

public static class MyClass
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        return a / b;
    }
    public static int Modulus(int a, int b)
    {
        return a % b;
    }
    public static int Power(int a, int b)
    {
        return Convert.ToInt32(Math.Pow(a, b));
    }
}