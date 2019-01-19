using System;
namespace DesignPattern.DecoratorPatternPractice
{
    public abstract class Meal
    {
        public string Description = "Unknown Meal";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();
    }
}
