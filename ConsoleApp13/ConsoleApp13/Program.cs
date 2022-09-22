using System.Diagnostics.Metrics;

namespace ConsoleApp13
{
    internal class Program
    {
        //Skapa en klass som kan användas som stegräknare.
        //Den ska ha en property Steps som bara går att läsa; en metod Step() 
        //som räknar upp Steps med 1 varje gång man anropar den; och en metod Reset() 
        //som nollställer räknaren.

        //Inputs... Integer that increments with every call.
        //Complex inputs... method for reseting steps.
        //Outputs... Every step the call makes, +1. Also Output for resetting.

        //For every method call, incremenet 1. if Space is pushed down, reset counter.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var counter = new StepCounter();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    counter.Step();
                }
                else if (key.Key == ConsoleKey.Spacebar)
                {
                    counter.Reset();
                    break;
                }
            }
            Console.WriteLine("Outside of loop now, bye!");
        }
    }
}