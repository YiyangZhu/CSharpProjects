﻿using System;
namespace DesignPattern.StatePattern
{
    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public override string ToString()
        {
            return "Sold Out State";
        }
    }
}
