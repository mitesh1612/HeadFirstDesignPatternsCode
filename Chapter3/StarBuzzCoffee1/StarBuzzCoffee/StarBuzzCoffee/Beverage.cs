using System;
using System.Collections.Generic;
using System.Text;

namespace StarBuzzCoffee
{
    public abstract class Beverage
    {
        public String description = "Unknown Beverage";
        
        public virtual String getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
