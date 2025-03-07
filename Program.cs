using Exception = System.Exception;

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



            // a number guessing game!



            // Random random = new Random();
            // bool playAgain = true;
            // int guess;
            // int number;
            // int guesses;
            // string response;
            //
            // while (playAgain)
            // {
            //     guess = 0;
            //     number = random.Next(1, 101);
            //     guesses = 0;
            //     while (guess != number)
            //     {
            //         Console.Write("Guess a number between 1 and 100:");
            //         guess = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Guess: " + guess);
            //         if (guess > number)
            //         {
            //             Console.WriteLine("Your guess is too high!");
            //         }
            //         else if (guess < number)
            //         {
            //             Console.WriteLine("Your guess is too low!");
            //         }
            //         guesses++;
            //     }
            //     Console.WriteLine("The number was: " + number);
            //     Console.WriteLine("You won!");
            //     Console.WriteLine("It took you " + guesses + " guesses to play!");
            //     Console.WriteLine("Do you want to play again? Y/N");
            //     response = Console.ReadLine();
            //     response = response.ToUpper();
            //     if (response == "Y" || response == "YES")
            //     {
            //         playAgain = true;
            //     }
            //     else
            //     {
            //         playAgain = false;
            //     }
            // }
            // Console.WriteLine("Thank you!");





            // ROCK, PAPER, SCISSORS!!!
            // Random choice = new Random();
            // bool PlayAgain = true;
            // string player;
            // string computer;
            // while (PlayAgain)
            // {
            //     computer = "";
            //     player = "";
            //     while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            //     {
            //         Console.WriteLine("Enter your choice!!!: ");
            //         player = Console.ReadLine();
            //         player = player.ToUpper();
            //     }
            //
            //     computer = choice.Next(1, 4).ToString();
            //     switch (computer)
            //     {
            //         case "1":
            //         {
            //             computer = "ROCK";
            //             break;
            //         }
            //         case "2":
            //         {
            //             computer = "PAPER";
            //             break;
            //         }
            //         default:
            //         {
            //             computer = "SCISSORS";
            //             break;
            //         }
            //     }
            //     Console.WriteLine("Player: " + player);
            //     Console.WriteLine("Computer: " + computer);
            //     switch (player)
            //     {
            //         case "ROCK":
            //             if (computer == "ROCK")
            //             {
            //                 Console.WriteLine("It's a draw!");
            //             }
            //             else if (computer == "PAPER")
            //             {
            //                 Console.WriteLine("You lost! :(");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("You won! :)");
            //             }
            //
            //             break;
            //         case "PAPER":
            //             if (computer == "ROCK")
            //             {
            //                 Console.WriteLine("You won! :)");
            //             }
            //             else if (computer == "PAPER")
            //             {
            //                 Console.WriteLine("It's a draw!");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("You lost! :(");
            //             }
            //             break;
            //         case "SCISSORS":
            //             if (computer == "ROCK")
            //             {
            //                 Console.WriteLine("You lost! :(");
            //             }
            //             else if (computer == "PAPER")
            //             {
            //                 Console.WriteLine("You won! :)");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("It's a draw!");
            //             }
            //             break;
            //     }
            //     Console.WriteLine("Do you want to continue? (Y/N)");
            //     string response = Console.ReadLine();
            //     response = response.ToUpper();
            //     if (response == "Y")
            //     {
            //         PlayAgain = true;
            //     }
            //     else
            //     {
            //         PlayAgain = false;
            //     }
            // }
            
            
            
            //     CALCULATOR
            
            
            // int num1;
            // int num2;
            // int result;
            // do
            // {
            //     Console.Write("Enter first number: ");
            //     num1 = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("Enter second number: ");
            //     num2 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("\t- :Subtract");
            //     Console.WriteLine("\t+ :Add");
            //     Console.WriteLine("\t* :Multiply");
            //     Console.WriteLine("\t/ :Divide");
            //     Console.WriteLine("\t% :Modulus");
            //     Console.Write("Enter an option: ");
            //     switch (Console.ReadLine())
            //     {
            //         case "-":
            //             result = num1 - num2;
            //             Console.WriteLine(num1 + "-" + num2 + "=" + result);
            //             break;
            //         case "+":
            //             result = num1 + num2;
            //             Console.WriteLine(num1 + "+" + num2 + "=" + result);
            //             break;
            //         case "*":
            //             result = num1 * num2;
            //             Console.WriteLine(num1 + "*" + num2 + "=" + result);
            //             break;
            //         case "/":
            //             result = num1 / num2;
            //             Console.WriteLine(num1 + "/" + num2 + "=" + result);
            //             break;
            //         case "%":
            //             result = num1 % num2;
            //             Console.WriteLine(num1 + "%" + num2 + "=" + result);
            //             break;
            //         default:
            //             Console.WriteLine("Invalid option");
            //             break;
            //     }
            //
            //     Console.WriteLine("Do you want to play again? (Y/N)");
            // } while (Console.ReadLine().ToUpper() == "Y");
            // Console.WriteLine("Thank you!");
            // Console.ReadKey();

            
            
            
            // Multidimensional arrays
            
            // String[] alphabet0 = { "A", "B", "C" };
            // String[] alphabet1 = { "D", "E", "F" };
            // String[] alphabet2 = { "G", "H", "I" };
            // String[,] words = {{ "A", "B", "C" },
            //                    { "D", "E", "F" },
            //                    { "G", "H", "I" } };
            // for (int i = 0; i < words.GetLength(0); i++)
            // {
            //     for (int j = 0; j < words.GetLength(1); j++)
            //     {
            //         Console.Write(words[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }
            
            
            
            
            
            // CALCULATOR 2.0 USING CLASS AND METHODS
            // bool play = true;
            // string Continue;
            // int c, d;
            // while (play)
            // {
            //     Console.Write("Enter number c: " );
            //     c = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("Enter number d: " );
            //     d = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("\tChoose an option");
            //     Console.WriteLine("\t+ :ADD");
            //     Console.WriteLine("\t- :SUBTRACT");
            //     Console.WriteLine("\t* :MULTIPLY");
            //     Console.WriteLine("\t/ :DIVIDE");
            //     Console.WriteLine("\t% :MODULUS");
            //     Console.WriteLine("\t^ :POWER");
            //     Console.Write("Your option: ");
            //     switch (Console.ReadLine())
            //     {
            //         case "+":
            //             Console.WriteLine(MyClass.Add(c, d));
            //             break;
            //         case "-":
            //             Console.WriteLine(MyClass.Subtract(c, d));
            //             break;
            //         case "*":
            //             Console.WriteLine(MyClass.Multiply(c, d));
            //             break;
            //         case "/":
            //             Console.WriteLine(MyClass.Divide(c, d));  
            //             break;
            //         case "%":
            //             Console.WriteLine(MyClass.Modulus(c, d));
            //             break;
            //         case "^":
            //             Console.WriteLine(MyClass.Power(c, d));
            //             break;
            //     }
            //     Console.WriteLine("Wanna continue? (y/n)");
            //     Continue = Console.ReadLine().ToUpper();
            //     if (Continue == "Y")
            //     {
            //         play = true;
            //     }
            //     else if (Continue == "N")
            //     {
            //         play = false;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Invalid input. Try again.");
            //     }
            // }   
            //     
            //
            // Console.ReadKey();

            // Car Car1 = new Car("Mustang", "Red");
            // Car Car2 = new Car("Mustang", "Blue");
            // Car Car3 = new Car("Mustang", "Green");
            // Car.StartRace();

            var account = new BankAccount("Anastasiia", 1000);
            // BankAccount account2 = new BankAccount("Anastasiia", "0999446400", 1000); why not this one?
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            var person = new Person
            {
                Name = "Anastasiia",
                Age = 18
                
            };
            Person.Introduce(person.Name, person.Age);
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(12, 10);
                point.Move(null);    //a method Move(Point new Location) giving a Point object
                Console.WriteLine($"{point.X} {point.Y}");
                point.Move(12, -1);     //a method Move(int x, int y) giving numbers, type int cannot be null
                Console.WriteLine($"{point.X} {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }

        static void UseParamsModifier()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(2, 34, 5, 12, 4)); //params is for giving only numbers instead of an actual array [1,2,3,4...] if it was ...Add(int[] numbers)

        }

        static void UseOutModifier()
        {
            try
            {
                var num = int.Parse("abc"); //if the string cannot be converted to int, the program crashes
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }
            int number;
            var result = int.TryParse("123", out number); //here we declare a different number to "parse out from"
            if (result)
            {
                Console.WriteLine($"The number {number} is a valid integer.");
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }
    }
}
