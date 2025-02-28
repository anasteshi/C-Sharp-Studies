namespace BroCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter A: ");
            // double a = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Enter B: ");
            // double b = Convert.ToDouble(Console.ReadLine());
            // double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            // Console.WriteLine(c);
            String fullName = "Anastasiia Kholodiuk";
            Console.WriteLine(fullName.Replace(" ", "").ToLower().Insert(0, "@"));
            String PhoneNumber = "099-946-400";
            Console.WriteLine(PhoneNumber.Replace("-", ""));
            Console.ReadLine();
            Console.WriteLine("Thank you for your input!");

        }
    }
}
