using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;

namespace SimpleCode;

class Program
{
    static void Table()
    {
        string msg = "Тип {0, 8} |\t.NET {1, 8} |\tРозмір = {2} \t|\t MIN = {3, 30}\t| MAX = {4}";
        Console.Title = "Типи даних у C#";
        Console.WriteLine("\n\t\t\t\t\tЧИСЛОВІ (цілі) ТИПИ:\n");
        Console.WriteLine(string.Format(msg, "byte", nameof(Byte), sizeof(byte), byte.MinValue, byte.MaxValue));
        Console.WriteLine(string.Format(msg, "sbyte", nameof(SByte), sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
        Console.WriteLine(string.Format(msg, "short", nameof(Int16), sizeof(short), short.MinValue, short.MaxValue));
        Console.WriteLine(string.Format(msg, "ushort", nameof(UInt16), sizeof(ushort), ushort.MinValue, ushort.MaxValue));
        Console.WriteLine(string.Format(msg, "int", nameof(Int32), sizeof(int), int.MinValue, int.MaxValue));
        Console.WriteLine(string.Format(msg, "uint", nameof(UInt32), sizeof(uint), uint.MinValue, uint.MaxValue));
        Console.WriteLine(string.Format(msg, "long", nameof(Int64), sizeof(long), long.MinValue, long.MaxValue));
        Console.WriteLine(string.Format(msg, "ulong", nameof(UInt64), sizeof(ulong), ulong.MinValue, ulong.MaxValue));
        
        Console.WriteLine("\n\t\t\t\t\tЧИСЛОВІ (з плаваючою точкою) ТИПИ:\n");
        Console.WriteLine(string.Format(msg, "float", nameof(Single), sizeof(float), float.MinValue, float.MaxValue));
        Console.WriteLine(string.Format(msg, "double", nameof(Double), sizeof(double), double.MinValue, double.MaxValue));
        Console.WriteLine(string.Format(msg, "decimal", nameof(Decimal), sizeof(decimal), decimal.MinValue, decimal.MaxValue));
        
        Console.WriteLine("\n\t\t\t\t\tСИМВОЛЬНІ ТИПИ:\n");
        Console.WriteLine(string.Format(msg, "char", nameof(Char), sizeof(char), char.MinValue, "?"));
        Console.WriteLine(string.Format(msg, "string", nameof(String), "N/A", "N/A", "N/A"));

        Console.WriteLine("\n\t\t\t\t\tЛОГІЧНИЙ ТИП:\n");
        Console.WriteLine(string.Format(msg, "bool", nameof(Boolean), sizeof(bool), "False", "True"));
        
        Console.WriteLine("\n\t\t\t\t\tСПЕЦІАЛЬНІ ТИПИ:\n");
        Console.WriteLine(string.Format(msg, "object", nameof(Object), "N/A", "N/A", "N/A"));
        Console.WriteLine(string.Format(msg, "dynamic", "N/A", "N/A", "N/A", "N/A"));
    }
    public static bool GetCoolingStatus()
    {
        return true;
    }
    public static bool GetTemperatureStatus()
    {
        return false;
    }
    static void Main(string[] args)
    {
                                    //string parsing
        
        // string str = Console.ReadLine();
        // NumberFormatInfo nfi = new NumberFormatInfo();
        // {
        //     nfi.NumberDecimalSeparator = ".";
        // }
        // double a = double.Parse(str, nfi);
        // Console.WriteLine(a);


        // string str = Console.ReadLine();
        // try
        // {
        //     int integer = int.Parse(str);
        //     Console.WriteLine(integer);
        //     Console.WriteLine("Conversation successful");
        // }
        // catch (Exception)
        // {
        //     Console.WriteLine("Conversation failed");
        // }
        
                                    //string tryparsing
        
        // string str = Console.ReadLine();
        // int a;
        // int.TryParse(str, out a); //is not a correct way
        // bool result = int.TryParse(str, out a); //but that is 
        // if (result)
        // {
        //     Console.WriteLine(result);
        //     Console.WriteLine("\nOperation successful");
        // }
        // else
        // {
        //     Console.WriteLine("\nOperation failed");
        // }
        
        // Table();
        
                                    //arithmetic operators
        
        // double c = 5; 
        // int d = 6;
        // double num = c / d;
        
        // int c = 5; //alternative way
        // int d = 6;
        // double num = (double) c / d;
        // Console.WriteLine(num);
        
                                    //if with bools

        // int fanSpeed = 0;
        // bool isHighTemperature = false;
        // bool hasNoCooling = fanSpeed <= 0;
        // if (hasNoCooling || isHighTemperature)
        // {
        //     Console.WriteLine("\nHelp!!!");
        // }

                                    //same task but with methods
        
        // if (!GetTemperatureStatus())
        // {
        //     Console.WriteLine("Help!!");
        // }
        
                                    //switch
        
        // for (int i = 0; i < 4; i++)
        // {
        //     ConsoleKey key = Console.ReadKey().Key;
        //     switch (key)
        //     {
        //         case ConsoleKey.A:
        //             Console.WriteLine("\nYou pressed A");
        //             break;
        //         case ConsoleKey.B:
        //             Console.WriteLine("\nYou pressed B");
        //             break;
        //         case ConsoleKey.R:
        //             Console.WriteLine("\nYou pressed R");
        //             break;
        //     }
        // }
        
                                    //calculator using switch
                                    
        double firstValue, secondValue;
        string action;
        while (true)
        {
            Console.Clear();
            try
            {
                Console.WriteLine("\nEnter first value: ");
                firstValue = double.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter second value: ");
                secondValue = double.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter action '+', '-', '*', '/': ");
                action = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Oops!");
                Console.ReadKey();
                continue; //the code below will not be executed
            }
            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                    
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                    
                case "/":
                    if (secondValue == 0) //we can remove {} cuz there's only one line of code to be executed
                        Console.WriteLine("\nYou can't divide by 0");
                    else
                        Console.WriteLine(firstValue / secondValue);
                    break;
                default:
                    Console.WriteLine("\nInvalid action!");
                    break;
            }
            Console.ReadKey();
        }
    }
}