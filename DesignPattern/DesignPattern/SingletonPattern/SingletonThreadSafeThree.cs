using System;
namespace DesignPattern.SingletonPattern
{
    public class SingletonThreadSafeThree
    {
        private static readonly SingletonThreadSafeThree UniqueInstance = new SingletonThreadSafeThree();

        static SingletonThreadSafeThree()
        {

        }

        private SingletonThreadSafeThree()
        {
        }

        public static SingletonThreadSafeThree Instance()
        {
            return UniqueInstance;
        }

        public string GetDescription()
        {
            return "I'm thread safe using static constructor.";
        }
    }
}
