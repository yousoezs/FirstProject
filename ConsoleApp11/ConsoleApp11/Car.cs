using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Car
    {
        private string _modell;
        private string _colour;
        private int _price;

        public Car()
        {
            Modell = string.Empty;
            Colour = string.Empty;
            Price = 0;
        }
        public Car(string modell, string colour, int price)
        {
            Modell = modell;
            Colour = colour;
            Price = price;
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Colour 
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public string Modell
        { 
            get { return _modell; }
            set { _modell = value; }
        }
        public void HalfPrice()
        {
            int halfPrice = Price / 2;
            Console.WriteLine(halfPrice);
        }
        public override string ToString()
        {
            return $"{Modell} " +
                $"{Colour} " +
                $"{Price} ";
        }
    }
}
