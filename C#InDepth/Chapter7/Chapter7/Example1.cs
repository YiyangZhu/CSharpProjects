using System;
namespace Chapter7
{
    partial class Example1 <TFirst, TSecond> : IEquatable<string> where TFirst: class
    {
        public bool Equals(string other)
        {
            return false;
        }
    }
}
