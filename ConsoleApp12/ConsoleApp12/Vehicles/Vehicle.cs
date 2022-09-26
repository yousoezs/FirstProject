namespace ConsoleApp12.Vehicles
{
    public abstract class Vehicle : IMakeNoise
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
