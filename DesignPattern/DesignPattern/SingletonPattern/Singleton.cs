using System;
namespace DesignPattern.SingletonPattern
{
    public class Singleton
    {
        private static Singleton UniqueInstance;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if(UniqueInstance == null)
            {
                UniqueInstance = new Singleton();
            }
            return UniqueInstance;
        }


        public string GetDescription()
        {
            return "I'm a classic Singleton.";
        }
    }
}
