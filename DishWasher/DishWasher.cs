﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    public class DishWasher
    {
        public void hobart(Dish dish)
        {
            for (int side = 0; side < dish.sides.Count; side++)
            {
                Console.WriteLine("wasihing side " + dish.sides[side]);

            }

        }
    }
}