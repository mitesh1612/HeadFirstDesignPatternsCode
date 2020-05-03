using System;

namespace StatePattern1
{
    public class SoldState : State
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

		public void insertQuarter()
		{
			Console.WriteLine("Please wait, we're already giving you a gumball");
		}

		public void ejectQuarter()
		{
			Console.WriteLine("Sorry, you already turned the crank");
		}

		public void turnCrank()
		{
			Console.WriteLine("Turning twice doesn't get you another gumball!");
		}

		public void dispense()
		{
			gumballMachine.releaseBall();
			if (gumballMachine.getCount() > 0)
			{
				gumballMachine.setState(gumballMachine.getNoQuarterState());
			}
			else
			{
				Console.WriteLine("Oops, out of gumballs!");
				gumballMachine.setState(gumballMachine.getSoldOutState());
			}
		}

		public void refill() { }

		public override string ToString()
        {
			return "Dispensing a Gumball";
        }
	}
}