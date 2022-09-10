using System.Diagnostics.Metrics;
using System.Drawing;
using static System.Console;

namespace ConsoleApp7
{
    internal class Program
    {
        //Skriv en metod DrawBox(int width, int height)
        //När man anropar metoden ska den tömma konsolen och skriva ut en rektangel där de yttre tecknen består av ‘#’ och de inre av ‘-’ Exempel:
        //DrawBox(7, 4);
        //#######
        //#-----#
        //#-----#
        //#######
        static void Main(string[] args)
        {
            WriteLine("Skriv in 2 tal, första är bredd, andra är längd: ");
            int width = int.Parse(ReadLine());
            int height = int.Parse(ReadLine());
            DrawBox(width, height);
        }
        static int DrawBox(int width, int height)
        {
            Clear();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int length = height - 1;
                    if (i == 0 || i == length)
                    {
                        Write("#");
                    }
                    else if (j == 0 || j == width - 1)
                        Write("#");
                    else
                        Write("-");
                    if (j == width - 1)
                    {
                        Write("\n");
                    }
                }
            }
            return height;
            return width;
        }
    }
}