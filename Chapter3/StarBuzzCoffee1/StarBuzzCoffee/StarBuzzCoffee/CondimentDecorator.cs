using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzCoffee
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public override abstract String getDescription();
    }
}
