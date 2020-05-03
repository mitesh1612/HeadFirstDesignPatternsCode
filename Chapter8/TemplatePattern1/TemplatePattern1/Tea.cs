using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern1
{
    public class Tea : CaffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Steeping the Tea");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
