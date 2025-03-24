namespace Recursion;
class Program
{
    class Item
    {
        public int Value { get; set; }
        public Item Child { get; set; }
    }

    static Item GetItem()
    {
        return new Item()
        {
            Value = 5,
            Child = new Item()
            {
                Value = 6,
                Child = new Item()
                {
                    Value = 7,
                }
            }

        };
    }

    static void Print(in Item item)
    {
        // if (item != null)
        // {
        //     Console.WriteLine(item.Value);
        //     Print(item.Child);
        // }
        //===============================
        for (Item i = item; i != null; i = i.Child)
        {
            Console.WriteLine(i.Value);
        }
    }
    
    static void Recursion(int i)
    {
        Console.Write(i + " ");
        i++;
        if (i >= 5)
            return;
        Recursion(i);
    }

    static void PrintArray(int i, params int[] array)
    {
        if (i < array.Length)
        {
            Console.WriteLine(array[i]);
            PrintArray(i + 1, array);
        }
        
    }

    static void SumArray(int[] array, int i = 0, int sum = 0)
    { 
        if (i >= array.Length)
        {
            Console.WriteLine(sum);
            return;
        }
        sum += array[i];
        SumArray(array, i + 1, sum);
    }

    static int SumOfArray(int[] array, int i = 0)
    {
        if (i >= array.Length)
            return 0;
        return array[i] + SumOfArray(array, i+1);
    }

    static int SumOfDigits(int number)
    {
        if (number < 10)
            return number;
        // int digit = number % 10;
        // int nextDigit = number / 10;
        // return digit + SumOfDigits(nextDigit);
        //======================================
        return number % 10  + SumOfDigits(number / 10);
    }
    //========================================================
    static int SumOfDigitsLoop(int number)
    {
        int result = 0;
        while (number > 0)
        {
            result += number % 10;
            number /= 10;
        }
        return result;
    }
    
    static void Main(string[] args)
    {
        // for (int i = 0; i < 5; i++) //traditional way
        // {
        //     Console.Write(i + " ");
        // }
        // //==========================================
        // Console.WriteLine();
        // Recursion(1);
        
        // Item item = GetItem();
        // Print(item);
        
        int[] array = {1, 2, 3, 4, 5};
        // PrintArray(0, array);

        // SumArray(array);
        
        // SumOfArray(array);

        Console.WriteLine(SumOfDigits(517));

        Console.WriteLine(SumOfDigitsLoop(244) );
    }
}