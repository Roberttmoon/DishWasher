using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    class Spoon : Silverware, ICanHoldLiquid
    {
        bool liquidFiled;
        public Spoon()
        {
            sides.Add("inside");
        }
        public void canHoldLiquid()
        {

        }

    }
}
