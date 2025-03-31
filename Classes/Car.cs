namespace Classes;

public class Car
{
    private int speed;

    public void PrintSpeed()
    {
        if (speed == 0)
            Console.WriteLine($"The car has stopped");
        
        if (speed > 0)
            Console.WriteLine($"The car is driving forwar d with the speed of {speed} km/h");

        if (speed < 0)
            Console.WriteLine($"The car is driving backward with the speed of {speed} km/h");
    }

    public void DriveForward()
    {
        speed += 10;
    }

    public void Stop()
    {
        speed = 0;
    }

    public void DriveBackward()
    {
        speed -= 10;
    }
}