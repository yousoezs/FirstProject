using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    //Skapa en klass som kan användas som stegräknare.
    //Den ska ha en property Steps som bara går att läsa; en metod Step() 
    //som räknar upp Steps med 1 varje gång man anropar den; och en metod Reset() 
    //som nollställer räknaren.

    //Inputs... Integer that increments with every call.
    //Complex inputs... method for reseting steps.
    //Outputs... Every step the call makes, +1. Also Output for resetting.
    public class StepCounter
    {
        private int _steps;

        public int Steps
        {
            get { return _steps; }
            set { _steps = value; }
        }

        public void Step()
        {
            Steps++;
            Console.WriteLine($"Count of steps: {Steps}");
        }

        public void Reset()
        {
            Steps = 0;
            Console.WriteLine($"Count of steps reset, steps count: {Steps}");
        }
    }
}
