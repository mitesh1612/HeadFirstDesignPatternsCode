using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern1
{
    public class PancakeHouseIterator : Iterator
    {
        List<MenuItem> items;
        int position = 0;

        public PancakeHouseIterator(List<MenuItem> menuItems)
        {
            items = menuItems;
        }

        public bool hasNext()
        {
            if(position >= items.Count || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
    }
}
