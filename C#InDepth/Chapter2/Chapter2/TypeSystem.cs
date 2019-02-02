using System;
namespace Chapter2
{
    public class TypeSystem
    {
        public TypeSystem()
        {
        }

        public static void Demo()
        {
            string[] strings = new string[5];
            object[] objects = strings;
            /*
            objects[0] = new Button(); //Error1: Button cannot be found; Error2: cannot store data types other than string
            */           
        }
    }
}
