using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern1
{
    public abstract class CaffeineBeverage
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        public abstract void brew();
        public abstract void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }
    }
}
