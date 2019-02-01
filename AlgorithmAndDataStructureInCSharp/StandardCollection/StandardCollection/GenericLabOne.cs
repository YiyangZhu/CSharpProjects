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
            foreach(Student stud in students)
            {
                Console.WriteLine("Student first name is " + stud.FirstName);
            }
            Console.WriteLine("Before removing student3, student count is " + students.Count);
            students.Remove(stud3);
            Console.WriteLine("After removing student3, student count is " + students.Count);
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Program { get; set; }

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
