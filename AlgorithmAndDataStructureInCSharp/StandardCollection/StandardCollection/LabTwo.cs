using System;
using System.Collections;

namespace StandardCollection
{
    public class LabTwo
    {
        public LabTwo()
        {
        }

        public static void Demo()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            Console.WriteLine($"For key = \"rtf\", value = {openWith["rtf"]}");
            openWith["rtf"] = "winword.exe";
            Console.WriteLine($"For key = \"rft\", value = {openWith["rtf"]}");
            openWith["doc"] = "winword.exe";
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine($"Value added for key = \"ht\":{openWith["ht"]}");
            }

            foreach(DictionaryEntry de in openWith)
            {
                Console.WriteLine($"key is {de.Key} and value is {openWith[de.Value]}");
            }

            Console.WriteLine();
            foreach(string key in openWith.Keys)
            {
                Console.WriteLine($"key is {key} and value is {openWith[key]}");
            }
        }
    }
}
