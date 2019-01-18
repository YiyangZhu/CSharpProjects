using System;
namespace DesignPattern.StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior;
        public IQuackBehavior QuackBehavior;

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            FlyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }

        public void Swim()
        {
            Console.WriteLine("All ducks can swim.");
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
    }
}
