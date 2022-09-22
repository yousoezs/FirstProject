using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
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
    //IF Red were to be 10. Blue needs to be 90. IsEqual?
    //While Red OR Blue is not 100. ++.
    public class ColourFloat
    {
        private float _red = 50f;
        private float _blue = 50f;

        public float Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
                _blue = 100 - _red;
            }
        }

        public float Blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
                _red = 100 - _blue;
            }
        }
    }
}
