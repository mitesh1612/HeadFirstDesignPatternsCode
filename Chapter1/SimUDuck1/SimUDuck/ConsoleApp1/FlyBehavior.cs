using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuckApp
{
    public interface FlyBehavior
    {
        public void fly();
    }
     public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }

    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
