using System;

namespace StarBuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $ " + beverage.cost());

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine(beverage1.getDescription() + " $ " + beverage1.cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $ " + beverage2.cost());

            // Need to debug, the description is not reaching properly. For the solution right now, marked the method getDescription in Beverage class as virtual
            // And override that method in CondimentDecorator
        }
    }
}
