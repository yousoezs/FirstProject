namespace ConsoleApp12.Vehicles;

public class Airplane : Vehicle, IFly
{
    public bool JetEngine { get; set; }
    public override void PrintInfo()
    {
        Console.WriteLine($"This Airplane has a jet engine: {JetEngine}");
    }

    public void Fly()
    {
        Console.WriteLine($"Airplane is shoving itself trough the atmosphere");
    }

    public override void MakeSound()
    {
        Console.WriteLine("*VZOOOOOOM*");
    }
}