using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerRestaurant
{
    public class Whopper : IBurger
    {
        public Whopper()
        {
            Console.WriteLine("Adding bread...");
            Console.WriteLine("Adding meat...");
            Console.WriteLine("Adding chopped onions...");
            Console.WriteLine("Adding tomatoes...");
            Console.WriteLine("Adding lettuce...");
            Console.WriteLine("Adding mayo...");
            Console.WriteLine("Whopper ready!");
        }
        public void Describe()
        {
            Console.WriteLine("I'm a Whopper");
        }


    }
}
