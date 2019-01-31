using System;
using System.Collections;

namespace StandardCollection
{
    public class LabOne
    {
        public LabOne()
        {
        }

        public static void Demo()
        {
            ArrayList myArrList = new ArrayList();
            myArrList.Add("First Item");
            myArrList.Add(3);
            myArrList.Add(4.5);

            foreach(object obj in myArrList)
            {
                Console.WriteLine(obj);
            }

            myArrList = new ArrayList();
            myArrList.Add("First Item");
            myArrList.Add("Third Item");
            myArrList.Add("Second Item");

            myArrList.Sort();
            int itemIndex = myArrList.IndexOf("Third Item");
            foreach(object o in myArrList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine($"The third item is {myArrList[itemIndex]}");
        }
    }
}
