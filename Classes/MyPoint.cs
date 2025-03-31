namespace Classes;

public class MyPoint
{
    private int _x;
    private int _y;

    public MyPoint()
    {
        Y = 34;
    }
    public void Set(int x)
    {
        if (x < 0)
        {
            _x = 1;
            return;
        }
        if (x > 110)
        {
            _x = 110;
            return;
        }
        _x = x;
    }

    public int GetX()
    {
        return _x;
    }

    public int Y 
    {
        get { return _y; }
        private set { _y  = value; }
    }
    //same as
    public int Z { private get; set; }
}