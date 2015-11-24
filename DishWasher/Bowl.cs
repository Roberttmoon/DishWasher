using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    class Bowl : China, ICanHoldLiquid
    {
        public void canHoldLiquid()
        {
            Console.WriteLine("Im a plate that can hold liquid");
        }
    }
}
