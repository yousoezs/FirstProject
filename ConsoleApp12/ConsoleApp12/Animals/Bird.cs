namespace ConsoleApp12.Animals;

public class Bird : Animal, IFly
{
    public void Fly()
    {
        Console.WriteLine($"Bird is soaring majestically");
    }

    public override void MakeSound()
    {
        Console.WriteLine("*SQUAAK*");
    }
}