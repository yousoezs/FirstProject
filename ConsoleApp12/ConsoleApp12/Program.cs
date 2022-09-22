namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var mc = new MotorCycle();
            var vehicle = new Vehicle();

            car.TopSpeed = 200;
            car.NumberOfDoors = 4;
            car.MakeSound();

            mc.TopSpeed = 200;
            mc.HandLedBarStyle = "normal";
            mc.MakeSound();

            vehicle.TopSpeed = 200;
            vehicle.MakeSound();

            var vehicles = new List<Vehicle>();
            vehicles.Add(car);
            vehicles.Add(mc);
            vehicles.Add(vehicle);
            
            foreach(var s in vehicles)
            {
                s.MakeSound();
            }
        }
    }
}