using System;
namespace DesignPattern.StrategyPattern
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Mute();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck.");
        }
    }
}
