namespace BroCode;

public class Calculator
{
    public int Add(params int[] numbers)
    {
        var sum = 0;
        return sum += numbers.Sum();
    }
}