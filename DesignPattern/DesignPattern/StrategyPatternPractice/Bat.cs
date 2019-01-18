using System;
namespace DesignPattern.StrategyPatternPractice
{
    public class Bat : Animal
    {
        public Bat()
        {
            SleepBehavior = new SleepLong();
            EatBehavior = new EatInsect();
        }

        public override void Display()
        {
            Console.WriteLine("I am a bat.");
        }
    }
}
