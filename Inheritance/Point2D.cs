namespace Inheritance;

public class Point2D:MyClass
{
    private int X { get; set; }
    private int Y { get; set; }

    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public void Print()
    {
        Console.WriteLine($"\tx: {X}");
        Console.WriteLine($"\ty: {Y}");
    }
}