using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern1
{
    public interface Iterator
    {
        bool hasNext();
        Object next();
    }
}
