using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerRestaurant
{
    public class Rodeo : IBurger
    {
        public Rodeo()
        {
            Console.WriteLine("Adding bread...");
            Console.WriteLine("Adding meat...");
            Console.WriteLine("Adding fried onions...");
            Console.WriteLine("Adding bbq...");
            Console.WriteLine("Rodeo ready!");
        }
        public void Describe()
        {
            Console.WriteLine("I'm a Rodeo");
        }


    }
}
