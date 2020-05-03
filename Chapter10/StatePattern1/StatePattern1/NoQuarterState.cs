using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern1
{
    public class NoQuarterState : State
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter!");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void refill()
        {
            
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public override string ToString()
        {
            return "Waiting for Quarter";
        }
    }
}
