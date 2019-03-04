using System;
using System.Collections;
using System.Text;

namespace Chapter13
{
    public class OptionalParameter
    {
        public OptionalParameter()
        {
        }

        public IList LoadSth(String filename)
        {
            return LoadSth(filename, Encoding.UTF8);
        }

        public IList LoadSth(String filename, Encoding encoding)
        {
            return LoadSth(filename, Encoding.UTF8);
        }

        public static void Dump(int x, int y = 20, int z = 30)
        {
            Console.WriteLine("x={0} y={1} z={2}", x, y, z);
        }

        public static void Demo()
        {
            Dump(1, 2, 3);
            Dump(1, 2);
            Dump(1);
        }

        public static void Demo2()
        {
            Dump(1, 2, 3);
            Dump(x: 1, y: 2, z: 3);
            Dump(z: 3, y: 2, x: 1);
            Dump(1, y: 2, z: 3);
            Dump(1, z: 3, y: 2);
            Dump(1, y: 2, z: 3);
        }
    }
}
