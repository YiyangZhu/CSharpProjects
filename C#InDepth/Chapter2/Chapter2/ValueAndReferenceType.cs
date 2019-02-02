using System;
using System.IO;

namespace Chapter2
{
    public class ValueAndReferenceType
    {
        public ValueAndReferenceType()
        {
        }

        public static void Demo()
        {
            Point p1 = new Point(10,20);
            Point p2 = p1;
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Stream stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;
            Console.WriteLine("type of stream: " +  stream.GetType());
            Console.WriteLine("type of memory stream: " + memoryStream.GetType());

            int i = 5;
            object o = i;
            int j = (int)o;



        }

        public struct Point
        {
            int X;
            int Y;
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"Point: ({X},{Y})";
            }
        }
    }
}
