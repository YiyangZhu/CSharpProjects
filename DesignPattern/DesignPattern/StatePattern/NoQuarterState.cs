using System;
namespace DesignPattern.StatePattern
{
    public class NoQuarterState : IState
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine g)
        {
            this.gumballMachine = g;
        }

        public void Dispense()
        {
            Console.WriteLine("Dispensing...");
            gumballMachine.ReleaseBall();
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter was ejected.");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter.");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "No Quarter State";
        }
    }
}
