using System;
namespace DesignPattern.DecoratorPatternPractice
{
    public class Carrot : VegetableDecorator
    {
        Meal meal;
        public Carrot(Meal m)
        {
            meal = m;
        }

        public override double GetCost()
        {
            return meal.GetCost() + 1.0;
        }

        public override string GetDescription()
        {
            return meal.GetDescription() + ", Carrot";
        }
    }
}
