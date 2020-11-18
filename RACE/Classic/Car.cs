using System;
using System.Collections.Generic;
using System.Text;

namespace RACE
{
    class Car
    {
        public string NameOfCar { get; set; }
        public Car(string name)
        {
            this.NameOfCar = name;
        }
        public virtual int MaxSpeed()
        {
            return 220;
        }
        public virtual int EPower()
        {
            return 125;
        }
        public virtual int TimeToAccelerate()
        {
            return 13;
        }
        public virtual void ChooseColour() { }
        public virtual void Painting() { }
        public virtual int PutNewEngine() { return 0; }
        public virtual int Cost() { return 0; }
        public virtual void PrintCharacteristics()
        {
            Console.WriteLine("Your car :" + NameOfCar);
            Console.WriteLine("Colour : black");
            Console.WriteLine("Max speed" + MaxSpeed());
            Console.WriteLine("Power of engine" + EPower());
            Console.WriteLine("Cost" + Cost());
        }

    }

}


