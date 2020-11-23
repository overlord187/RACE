using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic.MechanicsOfTheGame
{
    class Movable :IRaceOnTheTrack
    {
        public Movable(IRaceOnTheTrack m)
        {
            RaceOnTheTrack = m;
        }
        public IRaceOnTheTrack RaceOnTheTrack { private get; set; }
        public void Move()
        {
            RaceOnTheTrack.Move();
        }
    }
}
