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

                                //params keyword
    
    static void MyMethod(params object[] parameters)
    {
        string message = "Type: {0} | Item: {1}";
        foreach (var item in parameters)
        {
            Console.WriteLine(message, item.GetType(), item);;
        }
    }
    
                                //optional parameters

    static int Sum(int a, int b, bool enableLogging = false) //is optional bc it's already initialized 
    {
        int result = a + b;
        if (enableLogging)
        {
            Console.WriteLine($"A: {a}");
            Console.WriteLine($"B: {b}");
            Console.WriteLine($"Sum: {result}");
        }
        return result;
    }
              
                                //named parameters

    static int Subtract(int a, int b, bool enableLogging = false)
    {
        int result = a - b;
        if (enableLogging)
        {
            Console.WriteLine($"A: {a}");
            Console.WriteLine($"B: {b}");
            Console.WriteLine($"Subtraction: {result}");
        }
        return result;
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
                                    
        // MyStruct myStruct = new MyStruct();
        // Stopwatch sw = Stopwatch.StartNew();
        // for (int i = 0; i < int.MaxValue; i++)
        // {
        //     Abar(myStruct);
        //     Console.WriteLine(i+1);
        // }
        // sw.Stop();
        // Console.Clear();
        // Console.WriteLine($"With in keyword: {sw.Elapsed}");
        // Console.ReadKey();
        // sw.Restart();
        // for (int i = 0; i < int.MaxValue; i++)
        // {
        //     Raba(myStruct);
        //     Console.WriteLine(i+1);
        // }
        // sw.Stop();
        // Console.Clear();
        // Console.WriteLine($"Without in keyword: {sw.Elapsed}");
        
        
                                    //params keyword
                                    
        
        // MyMethod("My name is Anastasiia", 18, "A", "D", true);
        
        
                                    //optional parameters


        // Sum(5, 3); //doesn't display anything
        // Sum(4,65, true); 
        
        
                                    //named parameters
                                    
                                    
        Subtract(b:8, a:2); //the order doesn't matter
        Subtract(b:4, a:10, enableLogging:true);
        //======================================
        int firstValue = 34;
        int secondValue = 50;
        Subtract(secondValue, firstValue, enableLogging:true); //easy to see what some variables are meant to store 
    }
} 