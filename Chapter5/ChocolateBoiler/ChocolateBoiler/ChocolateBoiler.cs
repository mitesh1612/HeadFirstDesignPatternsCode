using System;
using System.Collections.Generic;
using System.Text;

namespace ChocolateBoiler
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler uniqueInstance;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetChocolateBoiler()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }

        public void fill()
        {
            if(isEmpty())
            {
                empty = false;
                boiled = false;
            }
        }

        public void drain()
        {
            if(!isEmpty() && isBoiled())
            {
                empty = true;
            }
        }
        public void boil()
        {
            if(!isEmpty() && !isBoiled())
            {
                empty = false;
                boiled = true;
            }
        }

        public bool isBoiled()
        {
            return boiled;
        }

        public bool isEmpty()
        {
            return empty;
        }

        public void drain()
        {
            if(is)
        }
    }
}
