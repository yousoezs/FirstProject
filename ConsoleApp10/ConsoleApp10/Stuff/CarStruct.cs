using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Stuff
{
    public readonly struct CarStruct
    {
        public readonly int TopSpeed;
        public CarStruct(int topSpeed)
        {
            TopSpeed = topSpeed;
        }
    }
}
