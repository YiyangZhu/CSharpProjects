using System;
namespace DesignPattern.StatePattern
{
    public class HasQuarterState : IState
    {
        GumballMachine GumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter was ejected.");
            GumballMachine.SetState(GumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned crank.");
            GumballMachine.ReleaseBall();
            GumballMachine.SetState(GumballMachine.GetSoldState());
        }

        public override string ToString()
        {
            return "Has Quarter State";
        }
    }
}
