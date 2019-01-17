using System;
using System.Collections.Generic;

namespace MSCourse
{
    public class Degree
    {
        public String Type;
        public List<Course> CourseList = new List<Course>();

        public Degree()
        {
        }

        public Degree(string Type)
        {
            this.Type = Type;
        }
    }
}
