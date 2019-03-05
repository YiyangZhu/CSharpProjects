using System;
using System.Collections.Generic;

namespace Chapter13
{
    public class GenericVariance
    {
        public GenericVariance()
        {
        }

        public class Circle
        {
            Point p;
            int radius;

            public Circle(Point p, int r)
            {
                this.p = p;
                this.radius = r;
            }

            public override string ToString()
            {
                return "circle: " + p.ToString() + " radius: " + radius;
            }
        }

        public class Square
        {
            Point p;
            int length;

            public Square(Point p, int l)
            {
                this.p = p;
                this.length = l;
            }

            public override string ToString()
            {
                return "square: " + p.ToString() + " length: " + length;
            }
        }

        public class Point
        {
            int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return "(" + x + "," + y + ")";
            }
        }

        public static void Demo()
        {
            List<Circle> circles = new List<Circle>
            {
                new Circle(new Point(0,0),15),
                new Circle(new Point(10,5),20),
            };

            List<Square> squares = new List<Square>
            {
                new Square(new Point(5,10),5),
                new Square(new Point(-10,0),2),
            };

            foreach(Circle c in circles)
            {
                Console.WriteLine(c);
            }

            foreach (Square s in squares)
            {
                Console.WriteLine(s);
            }
        }
    }
}
