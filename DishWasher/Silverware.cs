﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    public abstract class Silverware : Dish
    {
        public Silverware()
        {
            sides.Add("top");
            sides.Add("bottom");
        }
    }
}