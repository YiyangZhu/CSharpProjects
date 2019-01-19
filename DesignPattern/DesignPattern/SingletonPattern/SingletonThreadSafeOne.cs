using System;
namespace DesignPattern.SingletonPattern
{
    public class SingletonThreadSafeOne
    {
        private static SingletonThreadSafeOne UniqueInstance = new SingletonThreadSafeOne();

        private SingletonThreadSafeOne()
        {

        }

        public static SingletonThreadSafeOne GetInstance()
        {
            return UniqueInstance;
        }

        public string GetDescription()
        {
            return "I'm a statically initialized Singleton.";
        }
    }
}
