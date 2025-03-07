namespace BroCode;

public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(Point newLocation)
    {
        if (newLocation == null)
            throw new ArgumentNullException("newLocation"); // throwing an exception t=so that we cant continue if its true
        Move(newLocation.X, newLocation.Y);
    }
}