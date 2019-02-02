using System;

namespace Chapter2
{
    delegate void StringProcessor(string input);

    public class DelegateDemo
    {
       



        public DelegateDemo()
        {
        }

        public static void Demo()
        {
            StringProcessor proc1, proc2;
            /*proc1 = new StringProcessor(StaticMethods.PrintString);
            InstanceMethods instance = new InstanceMethods();
            proc2 = new StringProcessor(instance.PrintString);
            */
            Person jon = new Person("Jon");
            Person tom = new Person("Tom");
            StringProcessor jonsVoice, tomsVoice, background;
            jonsVoice = new StringProcessor(jon.Say);
            tomsVoice = new StringProcessor(tom.Say);
            background = new StringProcessor(Background.Note);
            jonsVoice("Hello, son.");
            tomsVoice.Invoke("Hello, Daddy!");
            background("An airplane flies past.");
        }

        public class Person
        {
            string name;
            public Person(string name)
            {
                this.name = name;
            }

            public void Say(string message)
            {
                Console.WriteLine("{0} says: {1}", name, message);
            }
        }

        public class Background
        {
            public static void Note(string note)
            {
                Console.WriteLine("({0})", note);
            }
        }
    }
}
