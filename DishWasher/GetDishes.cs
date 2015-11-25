using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    class GetDishes
    {
        List<Dish> dishes;


        GetDishes()
        {
            dishes = new List<Dish>();
        }
        public void dishIntro()
        {
            Console.Write("Welcome To Dish Washer Xtream!");
            Console.Write("please enter the number of plates: ");

        }
    }
}
