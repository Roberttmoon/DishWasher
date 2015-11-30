using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    class Program
    {

        static void Main(string[] args)
        {

            DishWasher dWasher = new DishWasher();
            Dish tableSpoon1 = new Spoon();
            dWasher.hobart(tableSpoon1 /*dish Goes Here*/);


        }
    }
}
