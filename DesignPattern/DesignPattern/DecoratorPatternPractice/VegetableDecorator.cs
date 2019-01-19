using System;
namespace DesignPattern.DecoratorPatternPractice
{
    public abstract class VegetableDecorator : Meal
    {
        public abstract new string GetDescription();
        public abstract override double GetCost();
    }
}
