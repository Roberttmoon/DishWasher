using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishWasher
{
    public abstract class Dish : ICanGetClean
    {
        int weight;
        bool machineWash;
        bool clean;
        public List<string> sides = new List<string>();
        public void cleanable()
        {
            
        }
    }
}
