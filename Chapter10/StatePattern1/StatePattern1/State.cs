using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern1
{
    public interface State
    {
        // List of all the actions
        public void insertQuarter();
        public void ejectQuarter();
        public void turnCrank();
        public void dispense();

        public void refill();
    }
}
