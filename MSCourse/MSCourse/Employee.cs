using System;
namespace MSCourse
{
    abstract class Employee
    {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public virtual void Login()
        {

        }

        public virtual void Logout()
        {

        }

        public abstract void EatLunch();
    }
}
