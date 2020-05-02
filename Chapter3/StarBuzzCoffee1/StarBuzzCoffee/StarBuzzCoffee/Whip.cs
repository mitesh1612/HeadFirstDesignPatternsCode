using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzCoffee
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override String getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return beverage.cost() + 0.10;
        }
    }
}
