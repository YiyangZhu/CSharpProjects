using System;
using System.Collections;

namespace DataStructures
{

    public class HashTableDemo
    {
        public static Hashtable employees = new Hashtable();

        public HashTableDemo()
        {
        }

        public static void HashTableDemo_()
        {
            employees.Add("111-22-3333", "Scott");
            employees.Add("222-33-4444", "Sam");
            employees.Add("333-44-55555", "Jisun");

            string keyOne = "111-22-3333";
            string keyTwo = "111-00-3333";
            Search(keyOne);
            Search(keyTwo);


        }

        public static void Search(string keyOne)
        {
            if (employees.ContainsKey(keyOne))
            {
                string empName = (string)employees[keyOne];
                Console.WriteLine("Employee {0}'s name is: {1}",keyOne, empName);
            }
            else
            {
                Console.WriteLine("Employee {0} is not in the hash table...",keyOne);
            }
        }
    }
}
