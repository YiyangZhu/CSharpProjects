using System;
using System.Collections.Generic;

namespace StandardCollection
{
    public class GenericLabOne
    {
        public GenericLabOne()
        {
        }

        public static void Demo()
        {
            List<Student> students = new List<Student>();
            Student stud1 = new Student("Tom", "Thumb", 12, "Computer Science");
            Student stud2 = new Student("Fred", "Flintstone", 45, "Geology");
            Student stud3 = new Student("Mickey", "Mouse", 35, "Animation");
            students.Add(stud1);
            students.Add(stud2);
            students.Add(stud3);
            /*
            foreach(Student stud in students)
            {
                Console.WriteLine("Student first name is " + stud.FirstName);
            }
            Console.WriteLine("Before removing student3, student count is " + students.Count);
            students.Remove(stud3);
            Console.WriteLine("After removing student3, student count is " + students.Count);
            students.Add(stud3);
            */

            Random random = new Random();
            foreach(Student stud in students)
            {
                for(int i = 0; i < 5; i++)
                {
                    stud.GradeStack.Push(random.Next(40, 100));
                }
            }
            foreach(Student stud in students)
            {
                Console.Write($"Student name is {stud.FirstName} {stud.LastName}, grades are ");
                foreach(int i in stud.GradeStack)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
            }
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Program { get; set; }
            public Stack<int> GradeStack = new Stack<int>();

            public Student(string first, string last, int age, string prog)
            {
                this.FirstName = first;
                this.LastName = last;
                this.Age = age;
                this.Program = prog;
            }
        }


    }
}
