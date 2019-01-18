using System;
namespace DesignPattern.StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}
