using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerRestaurant
{

    class ConcreteBurgerFactory:BurgerFactory
    {
        public override IBurger MakeBurger(Burgers burger)
        {
            if(burger==Burgers.Rodeo)
            {
                return new Rodeo();
            }
            if (burger == Burgers.Whopper)
            {
                return new Whopper();
            }
            if (burger == Burgers.Stacker)
            {
                return new Stacker();
            }
            if (burger == Burgers.Steakhouse)
            {
                return new Steakhouse();
            }
            return new Whopper();
        }

    }
}
