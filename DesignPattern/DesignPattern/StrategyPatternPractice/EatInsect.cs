using System;
namespace DesignPattern.StrategyPatternPractice
{
    public class EatInsect : IEatBehavior
    {
        public void Eat()
        {
            Console.WriteLine("I eat insects.");
        }
    }
}
