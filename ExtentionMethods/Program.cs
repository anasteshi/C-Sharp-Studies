using Extention_methods_stalker;

namespace ExtentionMethods;

class Program
{
    static void Main(string[] args)
    {
        Friend friend = new Friend();
        friend.Name = "Anastasiia";
        friend.Greet();
        friend.AskForAge();
        friend.AskForHobby();
        friend.AskForEmail();

        friend.Chase();
    }
}