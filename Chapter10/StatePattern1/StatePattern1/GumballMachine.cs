using System;

namespace StatePattern1
{
    public class GumballMachine
    {
        State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;
        State winnerState;

        State state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            this.count = numberGumballs;
            if(numberGumballs > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void setState(State newState)
        {
            state = newState;
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if(count != 0)
            {
                count--;
            }
        }
        public int getCount()
        {
            return count;
        }

        public void refill(int count)
        {
            this.count += count;
            Console.WriteLine("The gumball machine was just refilled; it's new count is: " + this.count);
            state.refill();
        }

        public State getState()
        {
            return state;
        }

        public State getSoldOutState()
        {
            return soldOutState;
        }

        public State getNoQuarterState()
        {
            return noQuarterState;
        }

        public State getHasQuarterState()
        {
            return hasQuarterState;
        }

        public State getSoldState()
        {
            return soldState;
        }

        public State getWinnerState()
        {
            return winnerState;
        }

        public override string ToString()
        {
            string result = "";
            result += "\nMighty Gumball Inc.";
            result += "\nC# Enabled Standing Gumball Model #2020";
            result += "\nInventory " + count + " gumball";
            if (count != 1)
            {
                result += "s";
            }
            result += "\n";
            result += "Machine is " + state + "\n";
            return result.ToString();
        }
    }
}