using System;
namespace Chapter2
{
    public class BeyondC_1NewFeature
    {
        public BeyondC_1NewFeature()
        {
        }

        public static void Demo()
        {
            EventHandler handler;
            handler = new EventHandler(HandleDemoEvent);
            handler(null, EventArgs.Empty);

            handler = HandleDemoEvent;
            handler(null, EventArgs.Empty);

            handler = delegate (object sender, EventArgs e)
            {
                Console.WriteLine("Handled anonymously");
            };
            handler(null, EventArgs.Empty);
            handler = delegate
            {
                Console.WriteLine("Handled anonymously again.");
            };
            handler(null, EventArgs.Empty);
            /*
            MouseEventHandler mouseHandler = HandleDemoEvent;
            mouseHandler(null, new MouseEventArgs(MouseButtons.None, 0, 0, 0, 0));
            */

            Func<int, int, string> func = (x, y) => (x * y).ToString();
            Console.WriteLine(func(5, 20));

            var jon = new { Name = "Jon", Age = 31 };
            var tom = new { Name = "Tom", Age = 4 };
            Console.WriteLine("{0} is {1}", jon.Name, jon.Age);
            Console.WriteLine("{0} is {1}", tom.Name, tom.Age);

            dynamic o = "hello";
            Console.WriteLine("Length of o = \"hello\" is " + o.Length);
            o = new string[] { "hi", "there" };
            Console.WriteLine("Length of o = new string[] { \"hi\", \"there\" } is " + o.Length);

            int? x2 = null;
            if(x2 != null)
            {
                int y = x2.Value;
                Console.WriteLine("y is " + y);
            }
            else
            {
                Console.WriteLine("cannot assign y value as x is null. ");
            }
            int z = x2 ?? 10;
            Console.WriteLine("z is " + z);

        }

        static void HandleEventHandler(object sender, EventArgs e)
        {
        }


        public static void HandleDemoEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Handled by HandleDemoEvent");
        }


    }
}
