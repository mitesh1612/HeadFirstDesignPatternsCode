using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern1
{
    public class Coffee : CaffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Dripping Coffee thorugh Filter");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
