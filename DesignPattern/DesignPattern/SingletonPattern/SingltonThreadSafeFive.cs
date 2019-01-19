using System;
namespace DesignPattern.SingletonPattern
{
    public class SingltonThreadSafeFive
    {
        private static readonly Lazy<SingltonThreadSafeFive> lazy = new Lazy<SingltonThreadSafeFive>(() => new SingltonThreadSafeFive());

        public static SingltonThreadSafeFive Instance { get { return lazy.Value; } }

        private SingltonThreadSafeFive()
        {
        }

        public string GetDescription()
        {
            return "I'm thread safe using System.Lazy<T>.";
        }
    }
}
