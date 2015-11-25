using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    class Glassware : Dish, ICanHoldLiquid
    {
        public void canHoldLiquid()
        {
            Console.WriteLine("I may be full of water");
        }
        public Glassware()
        {
            sides.Add("inside");
            sides.Add("outside");
            sides.Add("bottom");
        }

    }
}
