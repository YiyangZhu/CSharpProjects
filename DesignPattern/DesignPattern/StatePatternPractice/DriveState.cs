using System;
namespace DesignPattern.StatePatternPractice
{
    public class DriveState : IStateTwo
    {
        public Car car;

        public DriveState(Car c)
        {
            this.car = c;
        }

        public void Accelerate()
        {
            Console.WriteLine("Valid command! Car is accelerating.");
        }

        public void Decelerate()
        {
            Console.WriteLine("Valid command! Car is decelerating.");
        }

        public void Start()
        {
            Console.WriteLine("Invalid command! Car already started.");
        }

        public void Stop()
        {
            Console.WriteLine("Valid command! Car has stopped.");
            car.SetState(new ParkState(car));
        }

        public override string ToString()
        {
            return "Car is at drive state.";
        }
    }
}
