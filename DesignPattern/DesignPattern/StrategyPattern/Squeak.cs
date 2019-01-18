﻿using System;
namespace DesignPattern.StrategyPattern
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
