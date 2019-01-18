using System;
namespace DesignPattern.StrategyPatternPractice
{
    public abstract class Animal
    {
        public ISleepBehavior SleepBehavior;
        public IEatBehavior EatBehavior;

        public void SetSleepBehavior(ISleepBehavior sb)
        {
            SleepBehavior = sb;
        }

        public void SetEatingBehavior(IEatBehavior eb)
        {
            EatBehavior = eb;
        }

        public void PerformSleep()
        {
            SleepBehavior.Sleep();
        }

        public void PerformEat()
        {
            EatBehavior.Eat();
        }

        public abstract void Display();
    }
}
