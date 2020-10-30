using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerRestaurant
{
    public class Steakhouse : IBurger
    {
        public Steakhouse()
        {
            Console.WriteLine("Adding bread...");
            Console.WriteLine("Adding grilled meat...");
            Console.WriteLine("Adding chopped onions...");
            Console.WriteLine("Adding bbq...");
            Console.WriteLine("Adding lettuce...");
            Console.WriteLine("Steakhouse ready!");
        }
        public void Describe()
        {
            Console.WriteLine("I'm a Steakhouse");
        }


    }
}
