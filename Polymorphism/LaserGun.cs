namespace Polimorfizm;

public class LaserGun:Weapon
{
    public override void Fire()
    {
        Console.WriteLine("Paw paw!");
    }

    public override int Damage {get { return 15; } }
}