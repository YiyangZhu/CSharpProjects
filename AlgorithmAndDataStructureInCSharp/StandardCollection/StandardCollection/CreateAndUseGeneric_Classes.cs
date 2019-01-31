using System;
namespace StandardCollection
{
    public class CreateAndUseGeneric_Classes
    {
        public CreateAndUseGeneric_Classes()
        {
        }

        public static void Demo()
        {
            CustomList<Coffee> clc = new CustomList<Coffee>();
            Coffee coffee1 = new Coffee();
            Coffee coffee2 = new Coffee();
            clc.Add(coffee1);
            clc.Add(coffee2);
            Coffee firstCoffee = clc[0];
            Console.WriteLine(firstCoffee);

        }

        struct Coffee
        {

        }

        public class CustomList<T>
        {
            public T this[int index] { get; set; }

            public void Add(T item)
            {
                // Method logic goes here.
            }
            public void Remove(T item)
            {
                // Method logic goes here.
            }
        }
    }
}
