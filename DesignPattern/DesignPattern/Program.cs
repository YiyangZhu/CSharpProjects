using System;
using DesignPattern.StrategyPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            RubberDuck rubberDuck = new RubberDuck();
            DecoyDuck decoyDuck = new DecoyDuck();

            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();

            decoyDuck.Display();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();

            ModelDuck modelDuck = new ModelDuck();
            modelDuck.SetFlyBehavior(new FlyWithRocketPower());
            modelDuck.SetQuackBehavior(new Mute());
            modelDuck.PerformFly();
            modelDuck.PerformQuack();

        }
    }
}
