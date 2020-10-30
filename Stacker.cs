using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerRestaurant
{
    public class Stacker : IBurger
    {
        public Stacker()
        {
            Console.WriteLine("Adding bread...");
            Console.WriteLine("Adding meat...");
            Console.WriteLine("Adding bacon...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Stacker ready!");
        }
        public void Describe()
        {
            Console.WriteLine("I'm a Stacker");
        }


    }
}
