using System;
namespace DesignPattern.StrategyPatternPractice
{
    public class Sloth : Animal
    {
        public Sloth()
        {
        }

        public override void Display()
        {
            Console.WriteLine("I am a sloth.");
        }
    }
}
