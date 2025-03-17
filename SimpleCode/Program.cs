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
        
        
        // int[] array = {1,2,3,4,4,6,4,8,8,1};
        // Console.WriteLine(array.Max());
        // Console.WriteLine(array.Min());
        // Console.WriteLine(array.Sum());
        // Console.WriteLine(array.Where((i) => i % 2 == 0).Sum());
        // Console.WriteLine(array.Where((i) => i % 2 != 1).Min());
        // int[] result = array.Distinct().ToArray(); //unique elements
        // int[] result = array.OrderBy(i => i).ToArray(); //from smallest to greatest
        // int[] result = array.OrderByDescending(i => i).ToArray(); //from greatest to smallest 
        // Array.Sort(array); //from smallest to greatest
        // Array.Reverse(array);
        // Array.Find(array, i => i < 5); //finds first needed element from left 
        // Array.FindLast(array, i => i < 5); //finds first needed element from right 
        // int[] result = Array.FindAll(array, i => i < 5); //finds an array of needed elements
        // int index = Array.FindIndex(array, i => i == 8); //finds index of an element that matches left to right
        // int index = Array.FindLastIndex(array, i => i == 8); //finds index of an element that matches right to left
       
        // int index1 = array.Where(i => i != 8).First(); //using methods finds an element

        // int index1 = array.First(i => i != 8); //a simpler version
        // int index1 = array.FirstOrDefault(i => i != 8); //for dealing with exception 
        // int[] result = array.Where(i => i < 5).ToArray();
        
        
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


                                    //indices and ranges

        // int[] array = {1,2,23,22,12,5,3,21,1,53,23,43432,0,23};
        // Console.WriteLine(array[array.Length - 1]); //instead of this = 23
        // Console.WriteLine(array[^1]); //we use this = 23
        // int[] array1 = array[1..9]; //from 1 to 8 the last index is exclusive
        // int[] array2 = array[..8]; //from 0 to 7
        // int[] array3 = array[..]; //gets all elements
        
                                    //index struct

        // Index index; //just declaration array4 = {int[]} int[3] Explore
        // Index index = ^3; //third index from the end
        
                    //or
        
        // Index index = new Index(3,false); //'instance' of Index struct
        // Console.WriteLine(array[index]); //43432 or 22
        
                                    //range struct
                                    
        // Range range = 1..4;
        
                    //or
                    
        // Range range = new Range(1,4); //basically 1..4 so there are Index struct values inside range
        // Range range = ^4..^1; //23, 43432, 0
        // Int32 a = new Int32(); //same as Int32 a = 0; hence Index, Range structs are just like Int32, String etc 
        // int[] array4 = array[range]; //indices from 1 to 4 (exclusive)
         
                                    
                                    //ranges and indices for string
                                    
                                    
        // string str = "Success";
        // Console.WriteLine(str[^1]); //string is an array of chars, basically – s
        // Console.WriteLine(str[^2..]); //ss
        
        
                                    //multidimensional arrays
                                    
                                    
        // int [,] array = new int[4, 3];
        // int [,] array =     //we can remove new int [,]
        // {
        //     { 1, 2, 3},
        //     {4, 5, 63},
        //     {4, 2, 3},
        //     {1, 1, 1}
        // };
        // array[1, 1] = 9;
        // Console.WriteLine(array[1, 1]);
        // foreach (var arr in array)
        // {
        //     Console.Write(arr + " ");
        // }
        // int[,] array = new int[3, 5];
        // array.GetLength(0); //dimensions
        // array.Rank(); //doesnt work??
        // for (int i = 0; i < array.GetLength(0); i++)         //is okay but not valid in OOP
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {   
        //         array[i, j] = random.Next(10);
        //         Console.Write(array[i, j] + " ");
        //     }
        //
        //     Console.WriteLine();
        // }
        
        
                                    //random array
        
        
        // int[,] array = new int[3, 5];
        // Random random = new Random();
        // for (int i = 0; i < array.GetLength(0); i++)    //but that is. SOLID principle    
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {   
        //         array[i, j] = random.Next(10);
        //     }
        //
        //     Console.WriteLine();
        // }
        //
        // for (int i = 0; i < array.GetLength(0); i++)         
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {
        //         Console.Write(array[i, j] + " ");
        //     }
        //
        //     Console.WriteLine();
        // }
        
        
                                    //input array
                                    
                                
        // int[,] array = new int[3, 3];
        // for (int i = 0; i < array.GetLength(0); i++)    
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {   
        //         array[i, j] = int.Parse(Console.ReadLine());
        //     }
        //
        //     Console.WriteLine();
        // }
        //
        // Console.WriteLine();
        //  
        // for (int i = 0; i < array.GetLength(0); i++)         
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {
        //         Console.Write(array[i, j] + " ");
        //     }
        //
        //     Console.WriteLine();
        // }
        
        
                                    //input str array
                                    
                                    
        // string[,] array = new string[3, 3];
        // for (int i = 0; i < array.GetLength(0); i++)    
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {   
        //         array[i, j] = Console.ReadLine();
        //     }
        //
        //     Console.WriteLine();
        // }
        //
        // Console.WriteLine();
        //  
        // for (int i = 0; i < array.GetLength(0); i++)         
        // {
        //     for (int j = 0; j < array.GetLength(1); j++)
        //     {
        //         Console.Write(array[i, j] + " ");
        //     }
        //
        //     Console.WriteLine();
        // }
        
        
                                    //jagged arrays
                                    
                                    
        int [][] array = new int[3][]; //array of array
        Console.WriteLine(array.Rank);
        array[0] = new int[3];
        array[1] = new int[5];
        array[2] = new int[1];
         
        // array[0][2] = 55;
        //
        // int[] arr = array[0];
        //
        // Console.WriteLine(arr[2]);
        
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = random.Next(10);
            }
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j]);
            }
            Console.WriteLine(); 
        }
        
        
    }
}