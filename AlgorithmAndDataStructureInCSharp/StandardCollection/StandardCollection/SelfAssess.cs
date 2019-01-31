using System;
using System.Collections;

namespace StandardCollection
{
    public class SelfAssess
    {
        public SelfAssess()
        {
        }

        public class Student
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public Stack GradeStack { get; set; }
            public Student(int id, string name)
            {
                Id = id;
                Name = name;
                GradeStack = new Stack();
            }
        }

        public static void Demo()
        {
            ArrayList students = new ArrayList()
            {
                new Student(001, "YY"),
                new Student(002, "KW"),
                new Student(003, "YK")
            };

            Random random = new Random();

            foreach(Student s in students)
            {
                s.GradeStack.Push(random.Next(80,100));
                s.GradeStack.Push(random.Next(80, 100));
                s.GradeStack.Push(random.Next(80, 100));
                s.GradeStack.Push(random.Next(80, 100));
                s.GradeStack.Push(random.Next(80, 100));
                s.GradeStack.Push(random.Next(80, 100));
            }
            foreach(Student s in students)
            {
                Console.WriteLine($"student id is {s.Id}, student name is {s.Name}");
                while (s.GradeStack.Count != 0)
                {
                    Console.Write(s.GradeStack.Pop() + " ");
                }
                Console.WriteLine("");
            }


        }
    }
}
