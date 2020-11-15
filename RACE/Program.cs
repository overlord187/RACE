using System;

namespace RACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE MOST EXTREME RACING EVER!!!");
            Console.WriteLine("Please a select a game mode"); // Classic or Heavinly
            string choice=Console.ReadLine();
            if (choice.Equals("Classic"))
            {
                Console.WriteLine("Enter your name");
                Game game = new Game(User.Player.name, new ClassicRacing());
                game.Start();
            }
            if (choice.Equals("Heavinly"))
            {
                Console.WriteLine("Enter your name");
                Game game = new Game(User.Player.name, new HeavinlyRacing());
                game.Start();
            }
            
        }
    }
}
