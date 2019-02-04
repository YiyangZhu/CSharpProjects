using System;
namespace Chapter4
{
    public class CSharp2
    {
        public CSharp2()
        {
        }

        public static void Demo()
        {
            NullableBox();
            Person turing = new Person("Alan Turing ", new DateTime(1912, 6, 23), new DateTime(1954, 6, 7));
            Person knuth = new Person("Donald Knuth ", new DateTime(1938, 1, 10), null);
            Console.WriteLine(turing);
            Console.WriteLine(knuth);

            PrintValueAsInt32(5);
            PrintValueAsInt32("some string");

        }

        public static void NullableBox()
        {
            int? nullable = 5;
            object boxed = nullable;
            Console.WriteLine(boxed.GetType());

            int normal = (int)boxed;
            Console.WriteLine(normal);
            Console.WriteLine(normal.GetType());
            Console.WriteLine(boxed == null);
            Console.WriteLine(nullable.HasValue);

            nullable = new int?();
            boxed = nullable;
            Console.WriteLine(boxed == null);

            nullable = (int?)boxed;
            Console.WriteLine(nullable.HasValue);
        }

        public class Person
        {
            DateTime birth;
            DateTime? death;
            string name;

            //use the null coalescing operator to make the code straightfoward
            /*
            Address contact = user.ContactAddress ?? order.ShippingAddress ?? user.BillingAddress;
             */           


            public TimeSpan Age
            {
                get
                {
                    if(death == null)
                    {
                        return DateTime.Now - birth;
                    }
                    else
                    {
                        return death.Value - birth;
                    }
                }
            }

            //way 2 of TimeSpan
            /*
             DateTime lastAlive = death ?? DateTime.Now;
             return lastAlive - birth;
             */          

                //way 3 of TimeSpan
                /*
                return (death?? DateTime.Now) - birth;  
                 */                


            public Person(string name, DateTime birth, DateTime? death)
            {
                this.birth = birth;
                this.death = death;
                this.name = name;
            }

            public override string ToString()
            {
                return $"name:{name}, birth:{birth.ToString("yyyy-MM-dd")}, death:{death?.ToString("yyyy-MM-dd")}";
            }
        }

        public static void PrintValueAsInt32(object o)
        {
            int? nullable = o as int?;
            Console.WriteLine(nullable.HasValue ? nullable.Value.ToString() : "null");
        }
    }
}
