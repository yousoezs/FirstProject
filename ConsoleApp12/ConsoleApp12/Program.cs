using System.Numerics;
using ConsoleApp12.Vehicles;
using ConsoleApp12.Animals;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var mc = new MotorCycle();
            var vehicles = new List<Vehicle>();

            car.TopSpeed = 200;
            car.NumberOfDoors = 4;
            car.MakeSound();

            mc.TopSpeed = 200;
            mc.HandLedBarStyle = "normal";
            mc.MakeSound();

            var plane = new Airplane();
            plane.TopSpeed = 1000;
            

            var zoe = new Dog();
            var wanda = new Fish();
            var orville = new Bird();

            var animals = new List<Animal>();

            animals.Add(zoe);
            animals.Add(wanda);

            var noiseMakers = new List<IMakeNoise>();

            noiseMakers.AddRange(vehicles);
            noiseMakers.AddRange(animals);
            foreach (var noiseMaker in noiseMakers)
            {
                noiseMaker.MakeSound();
            }

            var flyers = new List<IFly>();
            flyers.Add(orville);
            flyers.Add(plane);
            foreach (var flyer in flyers)
            {
                flyer.Fly();
            }
        }
    }
}