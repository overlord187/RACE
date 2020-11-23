using System;
using System.Collections.Generic;
using System.Text;

namespace RACE
{
    class HeavinlyRacing : IGame
    {
        public void Start()
        {
            Console.WriteLine("The game begins in Heavinly race mode...");
        }
        public void Finish()
        {
            Console.WriteLine("The race is over");
        }
    }
}
