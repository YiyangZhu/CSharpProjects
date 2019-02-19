using System;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialMethodDemo p = new PartialMethodDemo();
            /*all the following are invalid:
            StringHelper variable = null;
            StringHelper[] array = null;
            public void Method1(StringHelper x){}
            public Stringhelper Method1() {return null;}
            List<StringHelper> x = new List<StringHelper>();

        }
    }
}
