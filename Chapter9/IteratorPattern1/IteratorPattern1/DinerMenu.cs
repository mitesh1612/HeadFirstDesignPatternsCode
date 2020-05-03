using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern1
{
    public class DinerMenu : Menu
    {
        static int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            addItem("Vegetarian BLT", "(Fakin') Bacon with Lettuce & Tomato on Whole Wheat", true, 2.99);
            addItem("BLT", "Bacon with lettuce & tomato on whole weat", false, 2.99);
            addItem("Soup of the Day", "Soup of the day, with a side of potato salad", false, 3.29);
            addItem("Hotdog", "A Hotdog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }
        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem
            {
                Name = name,
                Description = description,
                IsVegetarian = vegetarian,
                Price = price
            };
            if(numberOfItems >= MAX_ITEMS)
            {
                throw new Exception("Sorry, menu is full! Can't add item to Menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
