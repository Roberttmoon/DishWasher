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
            China china = new China();
            DishWasher dWasher = new DishWasher();
            dWasher.hobart( china);
        }
    }
}
