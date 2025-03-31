namespace Classes;

enum Color
{
    White,
    Blue,
    Green,
    Red,
    Yellow,
    Orange
}
class Point
{
    private int _x = 1;
    private int _y = 3;
    private Color _color = Color.Green;

    public Point() {}
    public Point(int x, int y)
    {
        // this._x = x;
        // this._y = y;
        //or
        _x = x;
        _y = y;
        Console.WriteLine("{0}, {1}, {2}", _x, _y, _color);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Point p = new Point();
        // p.x = 10;
        // p.y = 20;
        // p.color = Color.Blue;
        // //====================
        // var car = new Car();
        // car.DriveForward();
        // car.PrintSpeed();
        // car.DriveForward();
        // car.PrintSpeed();
        // car.DriveForward();
        // car.PrintSpeed();
        // car.Stop();
        // car.PrintSpeed();
        
        
        
        Point point = new Point(3,5);
        Point point1 = new Point();


        
        Student student = new Student("Anastasiia", "Kholodiuk", 18, new DateTime(2006,12,23) );

        Student student1 = new Student(student); //copies values to student1
        Student student2 = student1; //shares a link, so if student1 is changed, student2 will be too 
        
        student.SetLastName("&&&&&&&&&&&");
        student1.SetLastName("#########");
        
        student.PrintStudent();
        Console.WriteLine();
        student1.PrintStudent();
        Console.WriteLine();
        student2.PrintStudent();
        
        
        
        MyPoint myPoint = new MyPoint();
        
        // myPoint.Y = 3; //is not possible cuz set accessor is private
        //but
        int y = myPoint.Y; //it is, because get is public
        Console.WriteLine(y);

        myPoint.Z = 4;
        // int z = myPoint.Z; //get is private
        
        myPoint.Set(23);
        myPoint.GetX();



    } 
}