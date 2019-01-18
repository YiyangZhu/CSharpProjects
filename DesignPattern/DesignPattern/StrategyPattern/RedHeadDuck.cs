using System;
namespace DesignPattern.StrategyPattern
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();

        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck.");
        }
    }
}
