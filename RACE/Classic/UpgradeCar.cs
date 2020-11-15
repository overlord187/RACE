using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class UpgradedCar : CarDecorator
    {
        
        public UpgradedCar(Car c) : base(c.NameOfCar, c)
        {

        }
        public override int PutNewEngine()
        {
            return car.EPower() + 50;
        }
        public override int Cost()
        {
            return car.Cost() + 800;
        }
        
    }
}
