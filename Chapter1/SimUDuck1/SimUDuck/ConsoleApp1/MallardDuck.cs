using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        override public void display()
        {
            Console.WriteLine("I'm a real Mallard Duck!");
        }
    }
}
