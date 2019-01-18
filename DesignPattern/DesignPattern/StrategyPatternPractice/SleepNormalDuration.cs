using System;
namespace DesignPattern.StrategyPatternPractice
{
    public class SleepNormalDuration : ISleepBehavior
    {
        public void Sleep()
        {
            Console.WriteLine("I sleep around ten hours per day.");
        }
    }
}
