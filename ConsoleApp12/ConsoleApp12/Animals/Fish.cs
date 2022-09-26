namespace ConsoleApp12.Animals;

public class Fish : Animal
{
    public override void Consume(string food)
    {
        Console.WriteLine($"Fish is slurping {food}");
    }
}