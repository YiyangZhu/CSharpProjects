using System;
namespace DesignPattern.StrategyPatternPractice
{
    public class EatPlant : IEatBehavior
    {
        public void Eat()
        {
            Console.WriteLine("I eat plants.");
        }
    }
}
