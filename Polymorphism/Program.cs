namespace Polimorfizm;

class Program
{
    static void Main(string[] args)
    {
        
        
                                    //virtual and override
                                    
                                    
        Person person = new Person();
        person.Drive(new SportCar());
                        
        
                                    //abstract
                                    
                                    
        // person.Fire(new Gun());
        //########################
        Weapon[] inventory = { new Bow(), new Gun(), new LaserGun() };
        foreach (var weapon in inventory)
        {
            person.Info(weapon);
            person.Fire(weapon);
            Console.WriteLine();
        }
    }
}