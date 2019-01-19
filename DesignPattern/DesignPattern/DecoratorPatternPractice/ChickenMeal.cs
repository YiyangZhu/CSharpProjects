using System;
namespace DesignPattern.DecoratorPatternPractice
{
    public class ChickenMeal : Meal
    {
        public ChickenMeal()
        {
            Description = "Chicken Meal";
        }

        public override double GetCost()
        {
            return 10.99;
        }
    }
}
