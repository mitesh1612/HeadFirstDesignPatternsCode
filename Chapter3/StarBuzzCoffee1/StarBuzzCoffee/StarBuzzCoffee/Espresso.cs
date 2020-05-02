using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzCoffee
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }

    }
}
