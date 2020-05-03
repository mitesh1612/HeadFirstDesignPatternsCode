using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern1
{
    public class PancakeHouseMenu : Menu
    {
        List<MenuItem> menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();
            addItem("K&B's Pancake Breakfast", "Pancakes with Scrambled Eggs, Toast", true, 2.99);
            addItem("Regular Pancake Breakfast", "Pancakes with friend Eggs, Sausage", false, 2.99);
            addItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            addItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
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
            menuItems.Add(menuItem);
        }

        public Iterator createIterator()
        {
            return new PancakeHouseIterator(menuItems);
        }

    }
}
