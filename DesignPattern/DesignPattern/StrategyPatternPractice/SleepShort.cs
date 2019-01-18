using System;
namespace DesignPattern.StrategyPatternPractice
{
    public class SleepShort : ISleepBehavior
    {
        public void Sleep()
        {
            Console.WriteLine("I sleep around four hours per day.");
        }
    }
}
