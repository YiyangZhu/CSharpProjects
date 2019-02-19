using System;
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("FriendAssembly")]

namespace Chapter7
{
    public class Source
    {
        internal static void InternalMethod() { }
        public static void PublicMethod() { }
    }

    public class Friend
    {
        static void Demo()
        {
            Source.InternalMethod();
            Source.PublicMethod();
        }
    }

    public class Enemy
    {
        static void Demo()
        {
            Source.PublicMethod();
        }
    }
}
