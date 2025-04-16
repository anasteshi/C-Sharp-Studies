namespace Polimorfizm;

public abstract class Weapon : IWeapon, IHasInfo
{
    public abstract void Fire();
    
    public abstract int Damage { get; }

    public void ShowInfo()
    {
        Console.WriteLine($"{GetType().Name} Damage: {Damage} ");
    }
}