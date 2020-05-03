using System;

namespace StatePattern1
{
    public class SoldOutState : State
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

		public void insertQuarter()
		{
			Console.WriteLine("You can't insert a quarter, the machine is sold out");
		}

		public void ejectQuarter()
		{
			Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
		}

		public void turnCrank()
		{
			Console.WriteLine("You turned, but there are no gumballs");
		}

		public void dispense()
		{
			Console.WriteLine("No gumball dispensed");
		}

		public void refill()
		{
			gumballMachine.setState(gumballMachine.getNoQuarterState());
		}

		public override string ToString()
        {
			return "Sold out";
        }
	}
}