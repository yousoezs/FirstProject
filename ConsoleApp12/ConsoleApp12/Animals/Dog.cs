namespace ConsoleApp12.Animals;

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"*WOOFWOOF*");
    }

    public override void Consume(string food)
    {
        Console.WriteLine($"Dog is omnomnoming {food}");
    }
}