using System;
namespace DesignPattern.StatePattern
{
    public class GumballMachine
    {
        public IState SoldOutState;
        public IState NoQuarterState;
        public IState HasQuarterState;
        public IState SoldState;

        public IState State;
        int Count = 0; 

        public GumballMachine(int numberGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);

            this.Count = numberGumballs;
            if(numberGumballs > 0)
            {
                State = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
        }

        public void Dispense()
        {
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if(Count != 0)
            {
                Count--;
            }
        }

        public int GetCount()
        {
            return Count;
        }

        public void Refill(int Count)
        {
            this.Count = Count;
        }

        public void SetState(IState state)
        {
            this.State = state;

        }
        public IState GetState()
        {
            return State;
        }

        public IState GetSoldOutState()
        {
            return SoldOutState;
        }

        public IState GetNoQuarterState()
        {
            return NoQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return HasQuarterState;
        }

        public IState GetSoldState()
        {
            return SoldState;
        }

        public override string ToString()
        {
            return "This gumball machine current state is: " + State + " and has " + Count + " balls left.";
        }
    }
}
