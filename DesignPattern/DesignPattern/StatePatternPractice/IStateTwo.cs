using System;
namespace DesignPattern.StatePatternPractice
{
    public interface IStateTwo
    {
        void Accelerate();
        void Decelerate();
        void Stop();
        void Start();
    }
}
