﻿using System;
namespace MSCourse
{
    public class Manager : Employee
    {
        private char payRateIndicator;
        private Employee[] emps;
        private string department;

        public Manager()
        {
        }

        public string Department { get => department; set => department = value; }
    }
}
