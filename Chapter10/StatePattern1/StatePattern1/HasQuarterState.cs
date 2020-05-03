using System;

namespace StatePattern1
{
    public class HasQuarterState : State
    {
        Random randomWinner = new Random(System.DateTime.Today.Millisecond);
        private GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if( (winner == 0) && (gumballMachine.getCount()>1))
            {
                gumballMachine.setState(gumballMachine.getWinnerState());
            }
            else
            {
                gumballMachine.setState(gumballMachine.getSoldState());
            }
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void refill() { }

        public override string ToString()
        {
            return "Waiting for Turn of Crank.";
        }

    }
}