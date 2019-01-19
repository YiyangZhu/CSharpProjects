using System;
namespace DesignPattern.StatePattern
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        
    }
}
