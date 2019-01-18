using System;
namespace DesignPattern.StrategyPatternPractice
{
    public class Giraffe : Animal
    {
        public Giraffe()
        {
            SleepBehavior = new SleepShort();
            EatBehavior = new EatPlant();
        }

        public override void Display()
        {
            Console.WriteLine("I am a giraffe.");
        }
    }
}
