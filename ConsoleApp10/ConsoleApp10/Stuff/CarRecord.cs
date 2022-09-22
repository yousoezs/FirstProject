using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Stuff
{
    public record class CarRecord
    {
        private int _topSpeed;

        public int TopSpeed
        {
            get { return _topSpeed; }
            set { _topSpeed = value; }
        }

    }
}
