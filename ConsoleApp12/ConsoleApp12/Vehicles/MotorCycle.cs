namespace ConsoleApp12.Vehicles
{
    public class MotorCycle : Vehicle
    {
		private string _handLedBarStyle;

		public string HandLedBarStyle
		{
			get { return _handLedBarStyle; }
			set { _handLedBarStyle = value; }
		}
		public override void MakeSound()
		{
			Console.WriteLine("BLUBLUB");
		}

        public override void PrintInfo()
        {
            Console.WriteLine("Motorcykel V6 Motor");
        }
    }
}
