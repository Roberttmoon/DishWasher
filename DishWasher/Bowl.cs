using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    class Bowl : China, ICanHoldLiquid
    {
        bool liquidFiled;
        public void canHoldLiquid()
        {
        }
        public Bowl()
        {
            sides.Add("inside");
            sides.Add("outside");
        }
    }
}
