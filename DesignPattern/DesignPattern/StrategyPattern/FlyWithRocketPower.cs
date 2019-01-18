using System;
namespace DesignPattern.StrategyPattern
{
    public class FlyWithRocketPower : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I fly with rocket power.");
        }
    }
}
