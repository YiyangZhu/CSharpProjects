using System;
using System.Collections.Generic;

namespace MSCourse
{
    public class UProgram
    {
        public List<Degree> DegreeList = new List<Degree>();
        public string ProgramName;

        public UProgram()
        {
        }

        public UProgram(string Name)
        {
            this.ProgramName = Name;
        }
    }
}
