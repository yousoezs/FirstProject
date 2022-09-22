using static System.Convert;

namespace ConsoleApp9
{
    internal class Program
    {
        //Inputs... Integers of positive and negative
        //Complex Inputs... Big integers, may require Long.
        //Output... Square root of integer to be perfect, not decimal.

        //For every integer check value.
        //Take Square Root of integer.
        //IF integer is decimal. Return -1
        //IF integer is int, return integer.
        static void Main(string[] args)
        {
            long number = 144;
            Console.WriteLine(FindNextSquare(number));
        }
        public static long FindNextSquare(long num)
        {
            double newNum = 0;

            newNum = Math.Sqrt(num);
            if ((newNum % 1) > 0)
            {
                return -1;
            }
            else
                return (long)newNum;

        }
    }
}