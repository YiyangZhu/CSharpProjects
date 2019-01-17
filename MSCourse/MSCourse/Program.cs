using System;

namespace MSCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrinksMachine dm = new DrinksMachine();

            ////use type inference, compile does not know type before initialization
            //var dm2 = new DrinksMachine();
            //dm.Make = "Fourth Coffee";
            //dm.Model = "Beancrusher 3000";
            //dm.Age = 2;
            //dm.MakeEspresso();

            //Console.WriteLine(dm.Location);
            //DrinksMachine dm3 = new DrinksMachine(3);
            ////Console.WriteLine(dm2.Age);

            //Console.WriteLine(dm3.Age);
            //Console.WriteLine(dm3.Location);
            //Console.WriteLine(dm3.Make);

            //double weightInKilos = 80;
            //double weightInPounds = Conversions.KilosToPounds(weightInKilos);
            //Console.WriteLine(weightInPounds);

            //Console.WriteLine(Math.Pow(2, 8));

            //var Car1 = new Car();

            //Car1.Color = "white";
            //Car1.Year = 2010;
            //Car1.Mileage = 11000;

            //Console.WriteLine($"This car is {Car1.Color},was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");

            //var Car2 = new Car("Red",2008);

            //Console.WriteLine($"This car is {Car2.Color}, and was built in {Car2.Year}");

            //Console.WriteLine($"There are {Car.CountCars()} cars in total.");

            //var InformationTechnology = new UProgram("Information Technology");
            //var Student1 = new Student();
            //var Student2 = new Student();
            //var Student3 = new Student();

            //var ProgrammingWithCSharp = new Course("Programming With C#");

            //ProgrammingWithCSharp.StudentList.Add(Student1);
            //ProgrammingWithCSharp.StudentList.Add(Student2);
            //ProgrammingWithCSharp.StudentList.Add(Student3);

            //var Teacher1 = new Teacher();
            //ProgrammingWithCSharp.TeacherList.Add(Teacher1);

            //var Degree1 = new Degree("Bachelor");
            //Degree1.CourseList.Add(ProgrammingWithCSharp);

            //InformationTechnology.DegreeList.Add(Degree1);

            //Console.WriteLine($"The name of the program is {InformationTechnology.ProgramName} and the degree it contains is {InformationTechnology.DegreeList[0].Type}.");

            //Console.WriteLine($"The name of the course in the degree is {InformationTechnology.DegreeList[0].CourseList[0].CourseName}.");

            //Console.WriteLine($"There are {Student.StudentNumber()} students in the course.");

            //var anAnonymousObject = new { Name = "Tom", Age = 65 };

            //Console.WriteLine("Name:{0} Age:{1}", anAnonymousObject.Name, anAnonymousObject.Age);

            //var secondAnonymousObject = new { Name = "Cathy", Age = 30 };

            //secondAnonymousObject = anAnonymousObject;

            //Console.WriteLine(secondAnonymousObject.Name + " " +secondAnonymousObject.Age);



            //Manager leadManager = new Manager();
            //leadManager.Login();



            //Coffee coffee1 = new Coffee();
            //IBeverage coffee2 = new Coffee();

            //IBeverage beverage = coffee1;

            //Coffee coffee3 = beverage as Coffee;
            ////OR
            //Coffee coffee4 = (Coffee)beverage;
            //Console.WriteLine(coffee4.IsFairTrade);



            var employee1 = new EmployeeTwo("Libby", 2000);
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmployee("Winter");

            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());

            var employee5 = new TechnicalEmployee("Emma");
            var employee6 = new BusinessEmployee("John");


            Console.WriteLine(employee5.employeeStatus() + "..." + employee6.employeeStatus());





        }
    }
}
