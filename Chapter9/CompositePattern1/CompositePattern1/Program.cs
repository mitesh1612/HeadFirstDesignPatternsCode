using System;

namespace CompositePattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert");
            MenuComponent allMenus = new Menu("ALL MENUS", "All Menus Combined");

            // Adding Pancake House Menu Items from previous code
            pancakeHouseMenu.add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with Scrambled Eggs, Toast", true, 2.99));
            pancakeHouseMenu.add(new MenuItem("Regular Pancake Breakfast", "Pancakes with friend Eggs, Sausage", false, 2.99));
            pancakeHouseMenu.add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            pancakeHouseMenu.add(new MenuItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59));
            // Adding Diner House Menu Items from previous code
            dinerMenu.add(new MenuItem("Vegetarian BLT", "(Fakin') Bacon with Lettuce & Tomato on Whole Wheat", true, 2.99));
            dinerMenu.add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole weat", false, 2.99));
            cafeMenu.add(new MenuItem("Soup of the Day", "Soup of the day, with a side of potato salad", false, 3.29));
            dinerMenu.add(new MenuItem("Hotdog", "A Hotdog, with saurkraut, relish, onions, topped with cheese", false, 3.05));
            // Newer menu items
            dinerMenu.add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89));
            dinerMenu.add(dessertMenu);
            dessertMenu.add(new MenuItem("Applie Pie", "Apple Pie with a flakey crust, topped with vanilla icecream", true, 1.59));
            cafeMenu.add(new MenuItem("Veggie Burger and Fries", "Vegetarian Burger on whole wheat bun, lettuce, tomato and fries", true, 3.69));
            cafeMenu.add(new MenuItem("Burrito", "A large Burrito, with whole wheat pinto beans, salsa, guacamole", true, 4.29));

            // Adding all menus to allMenus
            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);
            allMenus.add(cafeMenu);

            Waitress waitress = new Waitress(allMenus);
            waitress.printMenu();
        }
    }
}
