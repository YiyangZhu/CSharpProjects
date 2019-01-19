using System;
namespace DesignPattern.StatePatternPractice
{
    public class ParkState : IStateTwo
    {
        public Car car;

        public ParkState(Car c)
        {
            this.car = c;
        }

        public void Accelerate()
        {
            Console.WriteLine("Invalid command! Car is at park state, need to start before accelerating.");
        }

        public void Decelerate()
        {
            Console.WriteLine("Invalid command! Car is at park state, need to start before decelerating.");
        }

        public void Start()
        {
            Console.WriteLine("Valid command! Car is starting.");
            car.SetState(new DriveState(car));
        }

        public void Stop()
        {
            Console.WriteLine("Invalid command! Car is at park state, already stopped.");
        }

        public override string ToString()
        {
            return "Car is at park state.";
        }
    }
}
