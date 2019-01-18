using System;
namespace DesignPattern.StrategyPatternPractice
{
    public class SleepLong : ISleepBehavior
    {
        public void Sleep()
        {
            Console.WriteLine("I sleep more than 16 hours per day.");
        }
    }
}
