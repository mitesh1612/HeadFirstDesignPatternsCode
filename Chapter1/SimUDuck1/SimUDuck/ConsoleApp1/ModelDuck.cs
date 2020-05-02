using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        override public void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
