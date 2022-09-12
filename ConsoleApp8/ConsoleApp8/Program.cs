using static System.Console;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car player = new Car();

            player.Level = 17;
            player.Alive = true;
            player.Name = "Toni";

            player.PrintInfo();
            Console.WriteLine(player.ToString());
        }
    }
}