using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CompositePattern1
{
    // Composite class of the Composite Pattern
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name, description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent getChild(int i)
        {
            return menuComponents[i];
        }

        public override string getName()
        {
            return name;
        }

        public override string getDescription()
        {
            return description;
        }

        public override void print()
        {
            Console.Write("\n" + getName());
            Console.WriteLine(", " + getDescription());
            Console.WriteLine("-------------------------");
            // Not using iterator and dont know how to use IEnumerable yet
            foreach(var menuComponent in menuComponents)
            {
                menuComponent.print();
            }
        }
    }
}
