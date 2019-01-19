using System;
namespace DesignPattern.SingletonPattern
{
    public class SingletonThreadSafeTwo
    {
        private static SingletonThreadSafeTwo UniqueInstance = null;
        private static readonly object padlock = new object();

        private SingletonThreadSafeTwo()
        {
        }

        public static SingletonThreadSafeTwo Instance
        {
            get
            {
                lock (padlock)
                {
                    if(UniqueInstance== null)
                    {
                        UniqueInstance = new SingletonThreadSafeTwo(); 
                    }
                    return UniqueInstance;
                }
            }
        }

        public string GetDescription()
        {
            return "I'm a simple thread-safe singleton using padlock";
        }
    }
}
