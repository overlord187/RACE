using System;
using System.Collections.Generic;
using System.Text;

namespace RACE
{
    class Game
    {
        public string Name { get; set; }
        public Game(string name, IGame start)
        {
            this.Name = name;
            StartGame = start;
        }
        public IGame StartGame { private get; set; }
        public void Start()
        {
            StartGame.Start();
        }
    }
}
