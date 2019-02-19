using System;
namespace Chapter8
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        private static int InstanceCounter { get; set; }
        private static readonly object counterLock = new object();

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

            lock (counterLock)
            {
                InstanceCounter++;
            }
        }

        public struct Foo
        {
            public int Value { get; private set; }
            public Foo(int value)
            {
                this.Value = value;
            }
        }

        public struct Food
        {
            public int Value { get; private set; }
            public Food(int value) : this()
            {
                this.Value = value;
            }
        }
    }
}
