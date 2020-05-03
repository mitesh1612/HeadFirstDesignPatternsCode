using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern1
{
    public class Waitress
    {
        Menu pancakeHouseMenu;
        Menu dinerMenu;
        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }
        public void printMenu()
        {
            Iterator pancakeHouseIterator = pancakeHouseMenu.createIterator();
            Iterator dinerIterator = dinerMenu.createIterator();
            Console.WriteLine("MENU\n------\nBREAKFAST");
            printMenu(pancakeHouseIterator);
            Console.WriteLine("\nLUNCH");
            printMenu(dinerIterator);
        }

        private void printMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                printMenuItem(iterator.next() as MenuItem);
            }
        }

        private void printMenuItem(MenuItem menuItem)
        {
            Console.WriteLine(menuItem.Name + ", ");
            Console.WriteLine(menuItem.Price + " -- ");
            Console.WriteLine(menuItem.Description);
        }
    }
}
