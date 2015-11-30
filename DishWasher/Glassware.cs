using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    class Glassware : Dish, ICanHoldLiquid
    {
        bool liquidFiled;
        public void canHoldLiquid()
        {
        }
        public Glassware()
        {
            sides.Add("inside");
            sides.Add("outside");
            sides.Add("bottom");
        }

    }
}
