namespace Classes;

public class Student
{
    public Student(string lastName, DateTime dateOfBirth)
    {
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }

    public Student(string firstName, string lastName, uint age, DateTime dateOfBirth) : this(lastName, dateOfBirth)
    {
        _firstName = firstName;
        _age = age;
    }

    public Student(Student student)
    {
        _firstName = student._firstName;
        _lastName = student._lastName;
        _age = student._age;
        _dateOfBirth = student._dateOfBirth;
    }
    
    private string _firstName;
    private string _lastName;
    private uint _age;
    private DateTime _dateOfBirth;

    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }
    public void PrintStudent()
    {
        Console.WriteLine($"First name: {_firstName} Last name: {_lastName} Age: {_age} Birthday: {_dateOfBirth}");

    }
    public void PrintStudent(Student student)
    {
        Console.WriteLine($"First name: {_firstName} Last name: {_lastName} Age: {_age} Birthday: {_dateOfBirth}");
    }
}