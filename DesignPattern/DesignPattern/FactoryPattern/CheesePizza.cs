using System;
namespace DesignPattern.FactoryPattern
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Sauce = "Marinara Pizza Sauce";
            Toppings.Add("Fresh Mozzarella");
            Toppings.Add("Parmesan");
        }
    }
}
