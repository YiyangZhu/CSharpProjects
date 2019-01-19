using System;
namespace DesignPattern.DecoratorPatternPractice
{
    public class BeefMeal : Meal
    {
        public BeefMeal()
        {
            Description = "Beef Meal";
        }

        public override double GetCost()
        {
            return 12.99;
        }
    }
}
