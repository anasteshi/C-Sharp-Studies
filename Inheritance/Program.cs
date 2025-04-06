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

    static void Foo(object obj)
    {
        Point2D point = obj as Point2D; //but this way there'll be no exception
        if (point != null)
        {
            point.Print();
        }
    }

    static void Bar(object obj)
    {
        // if (obj is Point2D)
        // {
        //    Point2D point = (Point2D)obj; 
        //    point.Print();
        // }

        if (obj is Point2D point2D)
        {
            point2D.Print();
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
        
        
                                    //as in keywords


        MyClass obj = new Point2D(3, 5);
        object obj1 = new Point2D(3, 5);
        Point2D obj2 = (Point2D)obj1; //throws an exception 
        obj2.Print();
        object a = "Hello";
        object b = 10;
        
        Foo(obj);
        Bar(obj);
        
        
                                    //protected keyword
        
        
        A variable = new A();
        Console.WriteLine(variable.publicField); //ok
        // Console.WriteLine(variable.privateField); not ok, same for protected
        B variable2 = new B();
        Console.WriteLine(variable2.publicField); //ok
        // Console.WriteLine(variable2.privateField); nah
        variable2.Print();
    }
}