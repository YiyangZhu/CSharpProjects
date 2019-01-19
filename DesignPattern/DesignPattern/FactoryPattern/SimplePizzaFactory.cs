using System;
namespace DesignPattern.FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string Type)
        {
            Pizza Pizza = null;

            if(Type.Equals("cheese"))
            {
                Pizza = new CheesePizza();
            } else if (Type.Equals("pepperoni"))
            {
                Pizza = new PepperoniPizza();
            }
            return Pizza;
        }
    }
}
