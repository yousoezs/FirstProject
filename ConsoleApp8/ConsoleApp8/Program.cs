using static System.Console;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car player = new Car();

            //player.Level = 17;
            //player.Alive = true;
            //player.Name = "Toni";

            ////player.PrintInfo();
            ////WriteLine(player.ToString());

            //var players = new List<Car>();
            ////var tal = new List<int>();

            //players.Add(player);

            //for (int i = 100; i > 0; i--)
            //{
            //    var playeri = new Car();
            //    playeri.Name = $"Person{i}";
            //    playeri.Level = i;
            //    playeri.Alive = true;
            //    players.Add(playeri);
            //    //tal.Add(i);
            //}

            ////Använd Sort.
            ////tal.Sort();

            ////Använd reverse
            //players.Reverse();

            ////foreach (var s in tal)
            ////{
            ////    WriteLine(s);
            ////}
            ////Count motsvarar längd på arrayer.
            //for (int i = 0; i < players.Count; i++)
            //{
            //    WriteLine(players[i]);
            //}
            Car player = new Car();

            player.Level = 17;
            player.Alive = true;
            player.Name = "Toni";

            //player.PrintInfo();
            //WriteLine(player.ToString());

            var players = new Queue<Car>();
            //var tal = new List<int>();

            players.Enqueue(player);

            for (int i = 100; i > 0; i--)
            {
                var playeri = new Car();
                playeri.Name = $"Person{i}";
                playeri.Level = i;
                playeri.Alive = true;
                players.Enqueue(playeri);
                //tal.Add(i);
            }

            //Använd Sort.
            //tal.Sort();

            //Använd reverse
            players.Reverse();

            //foreach (var s in tal)
            //{
            //    WriteLine(s);
            //}
            //Count motsvarar längd på arrayer.
            for (int i = 0; i < players.Count; i++)
            {
                WriteLine(players.Peek());
            }
        }
    }
}