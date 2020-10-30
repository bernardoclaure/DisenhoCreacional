using System;

namespace BurgerRestaurant
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            BurgerFactory factory = new ConcreteBurgerFactory();
            IBurger steakhouse=factory.MakeBurger(Burgers.Steakhouse);
            steakhouse.Describe();
            IBurger burger=factory.SellBurger();
            burger.Describe();
            IBurger burger2 = factory.SellBurger();
            burger2.Describe();
        }
    }
}
