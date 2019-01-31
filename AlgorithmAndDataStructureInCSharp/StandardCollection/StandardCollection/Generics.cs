using System;
using System.Collections;
using System.Collections.Generic;
namespace StandardCollection
{
    public class Generics
    {
        public Generics()
        {

        }

        struct Coffee
        {

        }

        struct Tea
        {

        }

        public static void Demo()
        {
            var coffee1 = new Coffee();
            var coffee2 = new Coffee();
            var tea1 = new Tea();
            var tea2 = new Tea();
            var tea3 = new Tea();
            var arrayList1 = new ArrayList();
            arrayList1.Add(coffee1);
            arrayList1.Add(coffee2);
            arrayList1.Add(tea1);
            arrayList1.Add(tea2);
            arrayList1.Add(tea3);
            try
            {
                arrayList1.Sort();
            }
            catch
            {
                Console.WriteLine("Error in sort arrayList1");
            }

            foreach(object o in arrayList1)
            {
                Console.WriteLine($"{o} type is {o.GetType()}");
            }

            var arrayList2 = new List<Coffee>();
            Console.WriteLine("");
            try
            {
                arrayList2.Add(coffee1);
                arrayList2.Add(coffee2);
                //arrayList2.Add(tea1);
                //arrayList2.Add(tea2);
                //arrayList2.Add(tea3);
            }
            catch
            {
                Console.WriteLine("Error in adding all elements");
            }

            foreach (object o in arrayList2)
            {
                Console.WriteLine($"{o} type is {o.GetType()}");
            }
            Console.WriteLine("");
            int number1 = 1;
            arrayList1.Add(number1);
            int number2 = (int)arrayList1[arrayList1.Count-1];

            foreach (object o in arrayList1)
            {
                Console.WriteLine($"{o} type is {o.GetType()}");
            }
            Console.WriteLine("");

            var genericList2 = new List<Int32>();
            genericList2.Add(number1);
            int number3 = genericList2[0];

            foreach (object o in genericList2)
            {
                Console.WriteLine($"{o} type is {o.GetType()}");
            }
            Console.WriteLine("");


        }
    }
}
