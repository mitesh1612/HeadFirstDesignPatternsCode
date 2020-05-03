using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern1
{
    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new Exception("This Operation is not Supported!");
        }

        public virtual void remove(MenuComponent menuComponent)
        {
            throw new Exception("This Operation is not Supported!");
        }

        public virtual MenuComponent getChild(int i)
        {
            throw new Exception("This Operation is not Supported!");
        }

        public virtual string getName()
        {
            throw new Exception("This Operation is not Supported!");
        }

        public virtual string getDescription()
        {
            throw new Exception("This Operation is not Supported!");
        }

        public virtual double getPrice()
        {
            throw new Exception("This Operation is not Supported!");
        }

        public virtual bool isVegetarian()
        {
            throw new Exception("This Operation is not Supported!");
        }

        public virtual void print()
        {
            throw new Exception("This Operation is not Supported!");
        }
    }
}
