using System;
namespace DesignPattern.DecoratePattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract String GetDescription();
    }
}
