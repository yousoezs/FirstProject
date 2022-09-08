using static System.Console;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[] { 1, 3, 2, 5, 4, 9 };

            int temp = 0;

            for(int write = tal.Length - 1; write >= 0; write--)
            {
                for (int sort = 0; sort < tal.Length - 1; sort++)
                {
                    if (tal[sort] > tal[sort + 1])
                    {
                        temp = tal[sort + 1];
                        tal[sort + 1] = tal[sort];
                        tal[sort] = temp;
                    }
                }
                WriteLine($"Sorterat: {tal[write]}");
            }
        }
    }
}