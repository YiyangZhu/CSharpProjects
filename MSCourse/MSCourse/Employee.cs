using System;
namespace MSCourse
{
    public class Employee
    {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public Employee()
        {
        }

        public string EmpNumber
        {
            get
            {
                return empNumber;
            }
            set
            {
                empNumber = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                firstName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
    }
}
