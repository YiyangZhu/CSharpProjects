using System;
namespace DesignPattern.SingletonPattern
{
    public class SingletonThreadSafeFour
    {

        private SingletonThreadSafeFour()
        {
        }

        public static SingletonThreadSafeFour Instance { get { return Nested.instance; } }

        private class Nested
        {
            static Nested()
            {

            }
            internal static readonly SingletonThreadSafeFour instance = new SingletonThreadSafeFour();
        }

        public string GetDescription()
        {
            return "I'm thread safe using nested class.";
        }

    }
}
