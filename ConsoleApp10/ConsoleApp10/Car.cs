using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Car : Vehicle
    {
		private int _numberOfDoors;

		public int NumberOfDoors
		{
			get { return _numberOfDoors; }
			set { _numberOfDoors = value; }
		}

	}
}
