using System;
namespace DesignPattern.DecoratorPatternPractice
{
    public class Mushroom : VegetableDecorator
    {
        VegetableDecorator vegetable;
        public Mushroom(VegetableDecorator vege)
        {
            vegetable = vege;
        }

        public override double GetCost()
        {
            return vegetable.GetCost() + 4.5;
        }

        public override string GetDescription()
        {
            return vegetable.GetDescription() + ", Mushroom";
        }
    }
}
