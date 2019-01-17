using System;
namespace MSCourse
{
    public class TechnicalEmployeeTwo : EmployeeThree
    {
        public int successfulCheckIns = 5;

        public TechnicalEmployeeTwo(String name) : base(name, 75000)
        {

        }

        public override String employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
