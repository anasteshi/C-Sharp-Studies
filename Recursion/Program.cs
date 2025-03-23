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
    
    static void Main(string[] args)
    {
        // for (int i = 0; i < 5; i++) //traditional way
        // {
        //     Console.Write(i + " ");
        // }
        // //==========================================
        // Console.WriteLine();
        // Recursion(1);
        
        Item item = GetItem();
        Print(item);
    }
}