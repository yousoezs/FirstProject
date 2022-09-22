using System.Security.Cryptography.X509Certificates;
using ConsoleApp10.Stuff;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var CarClass = new Car() { TopSpeed = 20, NumberOfDoors = 5 };
            var mcClass = new Motorcycle() { TopSpeed = 25, HandleBarType = "Bock" };
            var vehicleClass = new Vehicle() { TopSpeed = 30 };

            CarClass.MakeSound();
            mcClass.MakeSound();
            vehicleClass.MakeSound();

            Vehicle[] vehichles = new Vehicle[3];
            vehichles[0] = vehicleClass;
            vehichles[1] = mcClass;
            vehichles[2] = CarClass;

            for(int i = 0; i < vehichles.Length; i++)
            {
                Console.WriteLine(vehichles[i].TopSpeed);
            }
        }   
    }
}