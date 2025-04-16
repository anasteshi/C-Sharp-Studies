namespace Polimorfizm;

public class Bow:Weapon
{
    public override void Fire()
    {
        Console.WriteLine("Pshhhhew!");
    }

    public override int Damage => 7;
}