using System;
namespace MSCourse
{
    public class BusinessEmployeeTwo : EmployeeThree
    {
        public double bonusBudget = 1000;

        public BusinessEmployeeTwo(String name) : base(name, 50000)
        {

        }

        public override String employeeStatus()
        {
            return this.toString() + " with a budget of " + this.bonusBudget;
        }
    }

}
