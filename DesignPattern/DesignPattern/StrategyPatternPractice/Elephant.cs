using System;
namespace DesignPattern.StrategyPatternPractice
{
    public class Elephant : Animal
    {
        public Elephant()
        {
            SleepBehavior = new SleepShort();
            EatBehavior = new EatPlant();
        }

        public override void Display()
        {
            Console.WriteLine("I am an elephant.");
        }
    }
}
