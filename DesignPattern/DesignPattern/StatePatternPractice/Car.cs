using System;
namespace DesignPattern.StatePatternPractice
{
    public class Car
    {
        public IStateTwo State;

        public Car()
        {
        }

        public void SetState(IStateTwo s)
        {
            State = s;
        }

        public IStateTwo GetState()
        {
            if(State == null)
            {
                Console.WriteLine("State is not available!");
                Environment.Exit(1);
            }
            return State;
        }

        public void Accelerate()
        {
            State.Accelerate();
        }

        public void Decelerate()
        {
            State.Decelerate();
        }

        public void Start()
        {
            State.Start();
        }

        public void Stop()
        {
            State.Stop();
        }
    }
}
