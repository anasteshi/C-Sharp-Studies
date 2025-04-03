namespace Inheritance;

class Program
{
    static void Pat(Animal animal)
    {
        Console.WriteLine($"Patting {animal.Name}...");
    }

    static void PrintAll(Animal[] animals)
    {
        foreach (var animal in animals)
        {
            animal.Print();
        }
    }
    
    static void Main(string[] args)
    {
        Cat cat = new Cat("Vasya", 1);
        // cat.Meow();
        // cat.Eat();
        // cat.Purr();
        Dog dog = new Dog("Mika", 3);
        // dog.Bark();
        // dog.Eat();
        // Pat(dog);
        Wolf wolf = new Wolf("Sonya", 10);
        Animal[] animals = {cat, dog, wolf};
        PrintAll(animals);
        //#########################################
        Point2D point2D = new (10, 20);
        Point3D point3D = new (4, 120, 30);
        point2D.Print();
        point3D.Print3D();
        
    }
}