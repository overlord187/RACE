using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class TunedCar : CarDecorator
    {
        public string Colour { get; set; }
        public TunedCar(Car c): base(c.NameOfCar, c)
        {
           
        }
        public override int Cost()
        {
            return car.Cost() + 500;
        }    
        public override void ChooseColour()
        {
            Console.WriteLine("Select a colour");
            Colour = Console.ReadLine();

        }
        public override void Painting()
        {

            Console.WriteLine("Your car are painting...");
            Console.WriteLine("The car was painted" + Colour); 
        }
    }
}
