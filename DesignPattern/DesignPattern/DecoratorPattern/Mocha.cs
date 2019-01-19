using System;
namespace DesignPattern.DecoratePattern
{
    public class Mocha : CondimentDecorator
    {
        CondimentDecorator beverage;
        public Mocha(CondimentDecorator beverage)
        {
            this.beverage = beverage;
        }
 
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return .50 + beverage.Cost();
        }
    }
}
