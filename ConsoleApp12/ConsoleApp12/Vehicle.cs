using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public abstract class Vehicle
    {
		private int _topSpeed;

		public int TopSpeed
		{
			get { return _topSpeed; }
			set { _topSpeed = value; }
		}
		public virtual void MakeSound()
		{
			Console.WriteLine("WROOOM");
		}

        public void PrintTopSpeed()
        {
			Console.WriteLine(TopSpeed);
        }

        public abstract void PrintInfo();
    }
}
