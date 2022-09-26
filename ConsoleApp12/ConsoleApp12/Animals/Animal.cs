namespace ConsoleApp12.Animals;

public abstract class Animal : IMakeNoise
{
    public virtual void Consume(string food)
    {
        Console.WriteLine($"Animal is devouring {food}");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("*BLUBLUB*");
    }
}