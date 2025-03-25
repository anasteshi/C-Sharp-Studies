namespace Enum;
//special value type 
class Program
{
    enum DayOfWeek:byte //default type of enum is int
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    
    static DayOfWeek GetNextDayOfWeek(DayOfWeek day)
    {
        if (day < DayOfWeek.Sunday)
            day += 1;
        return DayOfWeek.Monday;
    }
    
    enum Color
    {
        Black,
        Blue,
        Green,
        Yellow,
        Red,
        Pink
    }
    
    static void Main(string[] args)
    {
        ConsoleKey key = Console.ReadKey().Key;
        Console.WriteLine($"\nKey: {key}, code: {(int)key}");
        var values = System.Enum.GetValues(typeof(ConsoleKey));
        foreach (var value in values)
        {
            Console.WriteLine(value);
        }
        //==================================================
        DayOfWeek day = DayOfWeek.Sunday;
        Console.WriteLine(System.Enum.GetUnderlyingType(typeof(DayOfWeek)));
        Console.WriteLine(day);
        Console.WriteLine((int)day); //explicit conversion to int
        Console.WriteLine((DayOfWeek)3); //explicit conversion to enum DayOfWeek
        DayOfWeek nextDay = GetNextDayOfWeek(day);
        Console.WriteLine(nextDay);
        //=========================
        DayOfWeek dayOfWeek;
        byte number = 5; //but the enum doesn't have a value for 53
        // dayOfWeek = (DayOfWeek)number;
        //can ve fixed with:
        if (System.Enum.IsDefined(typeof(DayOfWeek),number))
        { 
            dayOfWeek = (DayOfWeek)number; //convert int to DayOfWeek
        }
        else
        {
            throw new Exception("Invalid DayOfWeek value!"); 
        }

        Console.WriteLine(dayOfWeek);
        //==================================================
        string str = Console.ReadLine();
        Color color = (Color)System.Enum.Parse(typeof(Color), str, true);
        Console.WriteLine(color);

    }

    
}