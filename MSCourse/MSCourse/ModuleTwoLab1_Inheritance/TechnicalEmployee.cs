using System;
namespace MSCourse
{
    public class TechnicalEmployee : EmployeeTwo
    {
        public int successfulCheckIns = 5;

        public TechnicalEmployee(String name) : base(name, 75000)
        {

        }

        public override String employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
