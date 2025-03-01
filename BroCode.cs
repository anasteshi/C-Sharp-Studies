namespace BroCode
{
     internal class Program
    {
        static void Main(string[] args)
        {
            
            
            // Console.WriteLine("Enter A: ");
            // double a = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter B: ");
            // double b = Convert.ToDouble(Console.ReadLine());
            // double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            // Console.WriteLine(c);
            
            
            // string fullName = "Ana";
            // Console.WriteLine(fullName.Replace(" ", "").ToLower().Insert(0, "@"));
            // String PhoneNumber = "099-946-400";
            // Console.WriteLine(PhoneNumber.Replace("-", ""));
            // string firstName = "NAme" + fullName.Substring(0, 3);
            // string firstName = "Name" + (fullName.Length >= 3 ? fullName.Substring(3) : "");
            // Console.WriteLine(firstName);
            
            
            // Console.WriteLine("Input your age");
            // int age = Convert.ToInt32(Console.ReadLine());
            // switch (age)
            // {
            //     case < 18:
            //         Console.WriteLine("Your age is 18");
            //         break;
            //     case int i when i == 18 && i < 65:
            //         Console.WriteLine("You are an adult");
            //         break;
            //     default:
            //         Console.WriteLine("You are a senior");
            //         break;
            // }
            
            
            // string input = "test";
            // var result = input switch
            // {
            //     string s => "It's a string", // Always matches
            //     _ => "Unknown" // Unreachable
            // };
            // Console.WriteLine(result);
            
            
            // Console.WriteLine("Input your age");
            // int age = Convert.ToInt32(Console.ReadLine());
            // string message = age switch
            // {
            //     < 18 => "You are a minor!",
            //     52 => "You are a sigma!",
            //     > 18 and < 65 => "You are an adult!",
            //     _ => "You are a senior!"
            // };
            // Console.WriteLine(message);
            
            
            // Console.WriteLine("Input your age");
            // uint age = Convert.ToUInt32(Console.ReadLine());
            // uint num = 3;
            // switch(age)
            // {
            //     case uint x when x < num:
            //         Console.WriteLine("You are a minor!");
            //         break;
            //     case 52:
            //         Console.WriteLine("You are a sigma!");
            //         break;
            //     case uint x when x > 92 || x < 65 :
            //         Console.WriteLine("You are an adult!");
            //         break;
            //     default:
            //         Console.WriteLine("Enter your real age...");
            //         break;
            // };
            
            
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // while (String.IsNullOrWhiteSpace(name))
            // {
            //     Console.WriteLine("Enter your name: ");
            //     name = Console.ReadLine();
            // }
            // Console.WriteLine("Hello, " + name.Replace(" ", "") + "!");
            
            
            // string name = "";
            // while ( name == " " || String.IsNullOrWhiteSpace(name))
            // {
            //     Console.WriteLine("Enter your name: ");
            //     name = Console.ReadLine();
            // }
            // Console.WriteLine("Hello, " + name.Replace(" ", "") + "!");
            
            
            // Console.Write("How many rows?: ");
            // int row = Convert.ToInt32(Console.ReadLine());
            // Console.Write("How many columns?: ");
            // int column = Convert.ToInt32(Console.ReadLine());
            // Console.Write("What character?: ");
            // char character = Convert.ToChar(Console.ReadLine());
            //
            // for (int i = 0; i < row; i++)
            // {
            //     for (int j = 0; j < column; j++)
            //     {
            //         Console.Write(character);
            //     }
            //     Console.WriteLine();
            // }
            
            
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine("Thank you for your input!");

        }
    }
}
