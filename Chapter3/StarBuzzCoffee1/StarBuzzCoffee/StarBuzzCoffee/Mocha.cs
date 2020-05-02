using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzCoffee
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override String getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return beverage.cost() + 0.20;
        }
    }
}
