using ExtentionMethods;

namespace Extention_methods_stalker;

static class Stalker
{
    public static void Chase(this Friend friend)
    {
        Console.WriteLine($"{friend.Name}...{friend.Age} years old...how cute...:)");
    }
}