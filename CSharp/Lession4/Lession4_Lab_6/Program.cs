using Lession4_Lab_6;

internal class Program
{
    private static void Main(string[] args)
    {
        Car mycar = new Car();

        Console.WriteLine("Calling myCar.Start()");
        mycar.Start();

        Console.WriteLine("Calling myCar.Turnleft()");
        mycar.TurnLeft();

        Console.WriteLine("Calling myCar.Accelerate()");
        mycar.Accelerate();

    }
}