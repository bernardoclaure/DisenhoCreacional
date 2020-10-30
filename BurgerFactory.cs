using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerRestaurant
{
    public enum Burgers
    {
        Whopper,
        Rodeo,
        Stacker,
        Steakhouse,
    }
    public abstract class BurgerFactory
    {
        public abstract IBurger MakeBurger(Burgers burger);
        public IBurger SellBurger()
        {
            int number;
            Console.WriteLine("Pick a Burger");
            Console.WriteLine("0.-Whopper");
            Console.WriteLine("1.-Rodeo");
            Console.WriteLine("2.-Stacker");
            Console.WriteLine("3.-Steakhouse");
            var burger = Console.ReadLine();
            Int32.TryParse(burger, out number);
            return MakeBurger((Burgers)number);

        }
    }

}
