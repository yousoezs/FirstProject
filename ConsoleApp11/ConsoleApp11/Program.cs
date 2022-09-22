using System.Collections.Generic;
using System.Reflection.Metadata;
using System;

namespace ConsoleApp11
{
    internal class Program
    {
        //Skriv en ny klass som motsvarar en bil.
        //Den ska ha privata fields för modell, pris och färg.
        //Skapa publika properties för att hämta eller ändra värdet på varje field.
        //Skriv en konstruktor till bilklassen som inte tar några parametrar.
        //Skriv en till konstruktor som tar en parameter för varje property som klassen har.
        //Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?

        //Skriv en metod till bilklassen med namnet HalfPrice.
        //När den anropas ska priset på bilen sänkas till hälften.
        static void Main(string[] args)
        {
            var car = new Car();
            car.Modell = "Audi A6";
            car.Colour = "Space Grey";
            car.Price = 64900;
            var car2 = new Car("Audi A6", "Space Blue", 64900);
            var car3 = new Car();

            car3.Price = 50000;
            car3.HalfPrice();

            Console.WriteLine(car2);

            Console.WriteLine(car.Modell);
            Console.WriteLine(car.Colour);
            Console.WriteLine(car.Price);
        }
    }
}