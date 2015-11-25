using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    class Spoon : Silverware, ICanHoldLiquid
    {
        public Spoon()
        {
            sides.Add("inside");
        }
        public void canHoldLiquid()
        {
            Console.WriteLine("Im Silverware that can hold liquid");
        }

    }
}
