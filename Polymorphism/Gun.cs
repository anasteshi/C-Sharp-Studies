namespace Polimorfizm;

public class Gun:Weapon
{
    public override void Fire()
    {
        Console.WriteLine("Boom!");
    }

    public override int Damage => 10;
}