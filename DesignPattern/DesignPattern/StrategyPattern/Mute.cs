using System;
namespace DesignPattern.StrategyPattern
{
    public class Mute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I cannot quack.");
        }
    }
}
