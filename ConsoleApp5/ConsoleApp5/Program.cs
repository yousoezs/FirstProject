using static System.Console;

namespace ConsoleApp5
{
    internal class Program
    {
        //Be användaren mata in en mening. Skriv ut det genomsnittliga antalet bokstäver i orden.
        static void Main(string[] args)
        {
            WriteLine("Type in a text!");
            string userInput = ReadLine();
            string[] words = userInput.Split(' ');
            if (userInput.Contains(" "))
            {
                userInput.Replace(" ", "");
            }
            double result = userInput.Length / words.Length;


            WriteLine($"Det genomsnittliga antalet bokstäver är: {result}");
        }
    }
}