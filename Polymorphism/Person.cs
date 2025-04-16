namespace Polimorfizm;

public class Person 
{
    public void Drive(Car car)
    {
        car.Drive();
    }

    public void Fire(IWeapon weapon)//(Weapon[] inventory)
    {
        weapon.Fire();
    }

    public void Info(IHasInfo hasInfo)
    {
        hasInfo.ShowInfo();
    }
}