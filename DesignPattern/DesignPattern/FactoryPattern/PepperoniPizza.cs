using System;
namespace DesignPattern.FactoryPattern
{
    public class PepperoniPizza : Pizza
    { 
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            Sauce = "Tomato Sauce";
            Toppings.Add("Pepperoni");
            Toppings.Add("Mushrooms");
            Toppings.Add("Onions");
        }
    }
}
