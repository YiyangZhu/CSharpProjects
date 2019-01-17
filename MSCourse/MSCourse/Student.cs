using System;
namespace MSCourse
{
    public class Student
    {
        public static int NumberOfStudent = 0;
        public Student()
        {
            NumberOfStudent++;
        }

        public static int StudentNumber()
        {
            return NumberOfStudent;
        }
    }
}
