using System.Diagnostics;

namespace Keywords;

class Program
{
    static void Foo(ref int value)
    {
        value++;
        Console.WriteLine(value);
    }

    static void Bar(out int value)
    {
        value = 0;
        value++;
        Console.WriteLine(value);
    }
    
    
    //for speed test

    struct MyStruct
    {
        public int a;
        public int b;
        public int c;
        public int d;
    }
    static void Abar(in MyStruct value)
    {
    }

    static void Raba(MyStruct value)
    {
    }
    

    static void Main(string[] args)
    {
                                    //keyword out and ref differences 
        
        
        // int a = 5;
        // Foo(ref a);
        
        // //int b; 
        // //Bar(out b);
        //================
        // Bar(out int b);
        
        // string str = Console.ReadLine();
        // int.TryParse(str, out int num);
        // Console.WriteLine(num);
        //================ 
        // int.TryParse(Console.ReadLine(), out int number); //if s: cannot be parsed to int, result'll be 0
        // Console.WriteLine(number);
        
                                    //speed test in and w/o in keyword
                                    
        MyStruct myStruct = new MyStruct();
        Stopwatch sw = Stopwatch.StartNew();
        for (int i = 0; i < int.MaxValue; i++)
        {
            Abar(myStruct);
            Console.WriteLine(i+1);
        }
        sw.Stop();
        Console.Clear();
        Console.WriteLine($"With in keyword: {sw.Elapsed}");
        Console.ReadKey();
        sw.Restart();
        for (int i = 0; i < int.MaxValue; i++)
        {
            Raba(myStruct);
            Console.WriteLine(i+1);
        }
        sw.Stop();
        Console.Clear();
        Console.WriteLine($"Without in keyword: {sw.Elapsed}");

    }
} 