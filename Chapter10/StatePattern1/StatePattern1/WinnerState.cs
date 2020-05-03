using System;

namespace StatePattern1
{
    public class WinnerState : State
    {
        private GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

		public void insertQuarter()
		{
			Console.WriteLine("Please wait, we're already giving you a Gumball");
		}

		public void ejectQuarter()
		{
			Console.WriteLine("Please wait, we're already giving you a Gumball");
		}

		public void turnCrank()
		{
			Console.WriteLine("Turning again doesn't get you another gumball!");
		}

		public void dispense()
		{
			gumballMachine.releaseBall();
			if (gumballMachine.getCount() == 0)
			{
				gumballMachine.setState(gumballMachine.getSoldOutState());
			}
			else
			{
				gumballMachine.releaseBall();
				Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
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
		}

		public void refill() { }

		public override string ToString()
        {
			return "Dispensing Gumballs for your Quarter because YOU'RE A WINNER!";
        }
	}
}