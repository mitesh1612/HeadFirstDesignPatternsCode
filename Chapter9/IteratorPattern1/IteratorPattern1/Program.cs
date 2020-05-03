using System;

namespace IteratorPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            waitress.printMenu();
        }
    }
}
