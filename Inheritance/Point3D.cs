using System.Drawing;

namespace Inheritance;

public class Point3D : Point2D
{
    private int Z { get; set; }

    public Point3D(int x, int y, int z) : base(x, y) //base
    {
        Z = z;
    }

    public void Print3D()
    {
        // base.Print(); //to use parent method Print(), but using base is redundant 
        Print();
        Console.Write($"\tz: {Z}");
    }
    
}