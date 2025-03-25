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
    public int x;
    public int y;
    public Color color;
}

class Student
{
    public string firstName;
    public string lastName;
    public uint age;
    public Guid id;

}
class Program
{
    static Student GetStudent(Student student)
    {
        student.id = Guid.NewGuid();
        student.firstName = "Anastasiia";
        student.lastName = "Kholodiuk";
        student.age = 18;
        return student;
    }

    static void PrintStudent(Student student)
    {
        Console.WriteLine(student.firstName + " " + student.lastName);
        Console.WriteLine(student.age);
        Console.WriteLine(student.id);
    }
    static void Main(string[] args)
    {
        Point p = new Point();
        p.x = 10;
        p.y = 20;
        p.color = Color.Blue;
        //====================
        var student = new Student();
        PrintStudent(GetStudent(student));
    }
}