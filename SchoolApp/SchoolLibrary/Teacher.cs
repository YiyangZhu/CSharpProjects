using System;
namespace SchoolLibrary
{
    public class Teacher : Person
    {
        public enum Subject
        {
            English, Math, Chinese, Physics, Music, Sports
        }

        public Subject SubjectToTeach { get; set; }

        public Teacher()
        {
        }
    }
}
