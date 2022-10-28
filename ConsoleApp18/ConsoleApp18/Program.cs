namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Counter(10);
            c.ThresholdReached += c_ThresHoldReached;
            Console.WriteLine("Press 'a' to add 1!");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("Adding one!");
                c.Add(1);
            }
        }

        static void c_ThresHoldReached(object sender, EventArgs e)
        {
            Console.WriteLine("Threshold is reached!");
            Environment.Exit(0);
        }
    }
}