using System;
namespace DesignPattern.FactoryPattern
{
    public class PizzaStore
    {
        public SimplePizzaFactory Factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.Factory = factory;
        }

        public Pizza OrderPizza(string Type)
        {
            Pizza pizza;
            pizza = Factory.CreatePizza(Type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
