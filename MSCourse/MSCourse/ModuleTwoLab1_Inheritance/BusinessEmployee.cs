using System;
namespace MSCourse
{
    public class BusinessEmployee : EmployeeTwo
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(String name) : base(name, 50000)
        {

        }

        public override String employeeStatus()
        {
            return this.toString() + "with a budget of " + this.bonusBudget;
        }
    }

}
