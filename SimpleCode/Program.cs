﻿namespace SimpleCode;

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
        Console.WriteLine(msg, "bool", nameof(Boolean), sizeof(bool), "False", "True");
        
        Console.WriteLine("\n\t\t\t\t\tСПЕЦІАЛЬНІ ТИПИ:\n");
        Console.WriteLine(msg, "object", nameof(Object), "N/A", "N/A", "N/A");
        Console.WriteLine(msg, "dynamic", "N/A", "N/A", "N/A", "N/A");
    }

    static int[,] GetRandomArray(int row, int column)
    {
        Random random = new Random();
        var result = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                result[i, j] = random.Next(10);
            }
        }
        return result;
        
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
                                    
        // double firstValue, secondValue;
        // string action;
        // while (true)
        // {
        //     Console.Clear();
        //     try
        //     {
        //         Console.WriteLine("\nEnter first value: ");
        //         firstValue = double.Parse(Console.ReadLine());
        //         Console.WriteLine("\nEnter second value: ");
        //         secondValue = double.Parse(Console.ReadLine());
        //         Console.WriteLine("\nEnter action '+', '-', '*', '/': ");
        //         action = Console.ReadLine();
        //     }
        //     catch (Exception)
        //     {
        //         Console.WriteLine("Oops!");
        //         Console.ReadKey();
        //         continue; //the code below will not be executed
        //     }
        //     switch (action)
        //     {
        //         case "+":
        //             Console.WriteLine(firstValue + secondValue);
        //             break;
        //         case "-":
        //             Console.WriteLine(firstValue - secondValue);
        //             break;
        //             
        //         case "*":
        //             Console.WriteLine(firstValue * secondValue);
        //             break;
        //             
        //         case "/":
        //             if (secondValue == 0) //we can remove {} cuz there's only one line of code to be executed
        //                 Console.WriteLine("\nYou can't divide by 0");
        //             else
        //                 Console.WriteLine(firstValue / secondValue);
        //             break;
        //         default:
        //             Console.WriteLine("\nInvalid action!");
        //             break;
        //     }
        //     Console.ReadKey();
        
                                    //while loop – even and odd numbers
        
        // Console.WriteLine("Enter start number");
        // int startNumber = int.Parse(Console.ReadLine());                            
        // Console.WriteLine("Enter limit number");
        // int limit = int.Parse(Console.ReadLine());
        // uint evenCount = 0;
        // uint oddCount = 0;
        // int evenSum = 0;
        // int oddSum = 0;
        // while (startNumber <= limit)
        // {
        //     Console.WriteLine(startNumber);
        //     if (startNumber % 2 == 0)
        //     {
        //         evenCount++;
        //         evenSum += startNumber;
        //     }
        //     else
        //     {
        //         oddCount++;
        //         oddSum += startNumber;
        //     }
        //     startNumber++;
        // }
        // Console.WriteLine($"Even numbers: {evenCount}");
        // Console.WriteLine($"Odd numbers: {oddCount}");
        // Console.WriteLine($"Sum of even numbers: {evenSum}");
        // Console.WriteLine($"Sum of odd numbers: {oddSum}");
        
                                    //for loop

        // for (int i = 0; i < 5; ++i)
        // {
        //     Console.WriteLine(i);
        //     System.Threading.Thread.Sleep(300);
        // }
        
                                    //nested for loops

        // Console.WriteLine("Enter symbol: ");
        // var symbol = Console.ReadLine();
        // Console.WriteLine("Enter height: ");
        // int height = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter width: ");
        // int width = Convert.ToInt32(Console.ReadLine());
        //
        // for (int i = 0; i < height; i++)
        // {
        //     Console.WriteLine();
        //     for (int j = 0; j < width; j++)
        //     {
        //         Console.Write("*");
        //     }
        // }

                                    //nested loops #1
        
        // Random random = new Random();
        // int rows = random.Next(1, 10); ;
        // int columns = random.Next(1, 10);
        // var myArray = GetRandomArray(rows, columns);
        // for (int i = 0; i < rows; i++)
        // {
        //     for (int j = 0; j < columns; j++)
        //     {
        //         Console.Write($"\t{myArray[i, j]}");
        //     }
        //     Console.WriteLine();
        //     Console.WriteLine();
        // }
        
        
                                    //nested loops #2.1

                                    
        // Console.Write("Enter symbol: ");
        // var symbol = Console.ReadLine();
        //
        // Console.Write("\nEnter height: ");
        // int height = Convert.ToInt32(Console.ReadLine());
        //
        // Console.Write("\nEnter width: ");
        // int width = Convert.ToInt32(Console.ReadLine());
        
        
        // for (int i = 0; i < height; i++)        // ****
        // {                                       // ***
        //     for (int j = i; j < width; j++)     // **
        //     {                                   // *
        //         Console.Write(symbol);
        //     }
        //     Console.WriteLine();
        // }
        
        
        // for (int i = 0; i < height; i++)             // *
        // {                                            // **
        //     for (int j = 0; j <= i; j++)             // ***
        //     {                                        // ****
        //         Console.Write(symbol);
        //         
        //     }
        //     Console.WriteLine();
        // }
        

        // int count = --width;
        // for (int i = 0; i < height; i++)            //      *
        // {                                           //     **
        //     for (int k = 0; k < count; k++)         //    ***
        //     {                                       //   ****
        //         Console.Write(" ");
        //     }
        //     count--;
        //     for (int j = 0; j <= i; j++)             
        //     {                                       
        //         Console.Write(symbol);
        //     }
        //     Console.WriteLine();
        // }
        
        
        // int count = 0;
        // for (int i = 0; i < height; i++)        //     ****
        // {                                       //      ***
        //     for (int k = 0; k < count; k++)     //       **
        //     {                                   //        *
        //         Console.Write(" ");
        //     } 
        //     count++;
        //     for (int j = i; j < width; j++)     
        //     {                                  
        //         Console.Write(symbol);
        //     }
        //     Console.WriteLine();
        // }
              
        
                                    //nested loops #2.2
        
        
        // for (int i = 0; i < height; i++)           // ****
        // {                                          // ***
        //     for (int j = width; j > i; j--)        // **
        //     {                                      // *
        //         Console.Write(symbol);
        //     }
        //     Console.WriteLine();
        // }         
        
        
        // for (int i = 0; i < height; i++)             // 1   *
        // {                                            //    **
        //     for (int j = width; j > i; j--)          //   ***
        //     {                                        //  ****
        //         Console.Write(" ");
        //     }
        //     for (int j = 0; j <= i; j++)             
        //     {                                        
        //         Console.Write(symbol);
        //         
        //     }
        //     Console.WriteLine();
        // }
        
        
        // for (int i = 0; i < height; i++)                                    // 2    *
        // {                                                                   //     **
        //     Console.SetCursorPosition(height - i, i + 6);                   //    ***
        //     for (int j = 0; j <= i; j++)                                    //   ****
        //     {                                        
        //         Console.Write(symbol);
        //         
        //     }
        // }
        
        
        // for (int i = 0; i < height; i++)        //     ****
        // {                                       //      ***
        //     for (int j = 0; j <= i; j++)        //       **
        //     {                                   //        *
        //         Console.Write(" ");
        //     }
        //     for (int j = i; j < width; j++)     
        //     {                                  
        //         Console.Write(symbol);
        //     }
        //     Console.WriteLine();
        // }
        
        
                                    //ternary operator
                                    
        // string storedPassword = "qwerty";
        // string enteredPassword = Console.ReadLine();
        // bool accessAllowed;
        // // if (enteredPassword == storedPassword) //with if-else tho else is redundant 
        // //     accessAllowed = true;
        // // accessAllowed = enteredPassword == storedPassword; //the best way
        // accessAllowed = enteredPassword == storedPassword? true : false; //redundant way
        // // Console.WriteLine(enteredPassword == storedPassword); //or just that
        // Console.WriteLine(accessAllowed);
        
        
        // int inputNumber = int.Parse(Console.ReadLine());
        // int outputNumber = (inputNumber >= 0) ? inputNumber : 0;
        // Console.WriteLine(outputNumber);
        
        
                                    //arrays
        
        // int[] array = new[]{1,2,3,4,5};
        // Console.WriteLine(array.ElementAt(1)); // what's the difference between cw(array[1]) and this?
        // Console.WriteLine(array[2]);
        // int[] array = {11, 22, 33, 44}; //another way of initialization 
        // int[] array = Enumerable.Repeat(1, 6).ToArray(); //repeat elements without using loops
        // int[] array = Enumerable.Range(1, 10).ToArray(); //fills array with 10 values, starting from 1
        
        
        // int[] array = { 12, 12, 23, 4, 6, 7 };
        // for (int i = 0; i < array.Length; i++)
        // {
        //     Console.WriteLine(array[i]);
        // }


        // Console.Write("Enter size of array: ");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int[] array = new int[size]; //array from input
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"\nEnter array[{i}]: ");
        //     array[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"{array[i]} ");
        // }

        
        // int[] array = {1,2,3,4,5}; //reverse array
        // for (int i = array.Length - 1; i > 0; i--)
        // {
        //     Console.WriteLine(array[i]);
        // }
        
        
        // int[] array = {1,2,3,4,5}; //sum of even numbers
        // int evenSum = 0;
        // for (int i = 0; i < array.Length; i++)
        // { 
        //     if (array[i] % 2 == 0)
        //         evenSum += array[i];
        // }
        // Console.WriteLine(evenSum);
        
        
        // int[] array = {-1,2,3,4,-5}; //min value
        // int minValue = array[0];
        // for (int i = 0; i < array.Length; i++)
        // {
        //     if (array[i] <= minValue)
        //     {
        //         minValue = array[i];
        //     }
        // }
        // Console.WriteLine(minValue);
        
        
        // int[] array = {-1,2,3,4,-5}; //max value
        // int maxValue = array[0];
        // for (int i = 0; i < array.Length; i++)
        // {
        //     if (array[i] > maxValue)
        //     {
        //         maxValue = array[i];
        //     }
        // }
        // Console.WriteLine(maxValue);
        
        // int[] array = {1,2,3,4,5,6,7,8,9,10};
        // Console.WriteLine(array.Max());
        // Console.WriteLine(array.Min());
        // Console.WriteLine(array.Sum());
        // Console.WriteLine(array.Where((i) => i % 2 == 0).Sum());
        // Console.WriteLine(array.Where((i) => i % 2 != 1).Min());


                                    //ex. <unique values of an array>
        
        
        // int[] array = { 1, 2, 3, 4, 2, 2, 3, 4 };
        // int newArrayLength = 0;
        // int uniqueNumber = 0;
        //
        // for (int i = 0; i < array.Length; i++)
        // {
        //     int uniqueCheck = 0;
        //     for (int j = 0; j <= i; j++)
        //     {
        //         if (array[j] == array[i])
        //         {
        //             uniqueCheck++;
        //         }
        //     }
        //     if (uniqueCheck == 1)
        //     {
        //         newArrayLength++;
        //     }
        // }
        //
        // int[] uniqueArray = new int[newArrayLength];
        //
        //                      // output unique array
        //
        // for (int i = 0; i < array.Length; i++)
        // {
        //     int uniqueCheck = 0;
        //     for (int j = 0; j <= i; j++)
        //     {
        //         if (array[j] == array[i])
        //         {
        //             uniqueCheck++;
        //         }
        //     }
        //     if (uniqueCheck == 1)
        //     {
        //         uniqueArray[uniqueNumber] = array[i];
        //         uniqueNumber++;
        //     }
        // }
        // for (int i = 0; i < uniqueArray.Length; i++)
        // {
        //     Console.Write(uniqueArray[i]+" ");
        // }
        
        
        
        
        
    }
}