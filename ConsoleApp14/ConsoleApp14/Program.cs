namespace ConsoleApp14
{
    internal class Program
    {
        //Skapa en en klass som har en property “red” och en property “blue”. 
        //Båda ska vara en float och kunna ha ett värde mellan 0.0 och 100.0 men de ska vara, 
        //“sammankopplade” på så vis att värdena tillsammans alltid är 100.0
        //d.v.s om man t.ex.sätter “blue” till 8.5 och sedan läser av “red” så ska den returnera 91.5

        //Inputs... A property "red" and a property "Blue", together should equal 100.
        //Complex Input... IF Red is 1.5, Blue need to be 98.5.
        //Output... Either property gets a value, the other prop needs to fill in the rest to equal 100.

        //Create 2 private floats.
        //Connect them so both equals always 100.
        //IF Red were to be 10. Blue needs to be 90.
        //Check for userInput for colour.
        //IF Red, let the user enter a new input for the color red.
        //Take new input and take the sub of Blue. Vice versa.
        static void Main(string[] args)
        {
            var colours = new ColourFloat();

            Console.WriteLine("Blue or Red?");
            string userInput = Console.ReadLine();

            if (userInput == "Red")
            {
                Console.WriteLine("What value do you want to assign to red?");
                colours.Red = float.Parse(Console.ReadLine());
                Console.WriteLine($"Red is {colours.Red}, Blue is {colours.Blue}");
            }
            else if (userInput == "Blue")
            {
                Console.WriteLine("What value do you want to assign to Blue?");
                colours.Blue = float.Parse(Console.ReadLine());
                Console.WriteLine($"Red is {colours.Red}, Blue is {colours.Blue}");
            }
            else
                Console.WriteLine("Wrong input, terminating...");

            Console.ReadKey();
        }
    }
}