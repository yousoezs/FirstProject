using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Vehicle
    {
        private int _topSpeed;

        public int TopSpeed
        {
            get { return _topSpeed; }
            set { _topSpeed = value; }
        }
        public void MakeSound()
        {
            Console.WriteLine("Wroom");
        }
    }
}
