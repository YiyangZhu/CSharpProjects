using System;
using System.Collections.Generic;

namespace MSCourse
{
    public class Course
    {
        //array example: int[] scores = new int[] { 97, 92, 81, 60 };
        //public Student[] Students;
        //public Teacher[] Teachers;

        //list is better
        //var list = new List<int>();
        //list.Add(1);
        //list.Add(2);
        //list.Add(3);
        public List<Student> StudentList = new List<Student>();
        public List<Teacher> TeacherList = new List<Teacher>();
        public string CourseName;

        public Course()
        {
        }

        public Course(string Name)
        {
            this.CourseName = Name;
        }
    }
}
