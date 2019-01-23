using System;

namespace FirstConsoleApp
{
    class Program
    {
        public enum weekdays { Monday = 1, Tuesday =2 , Wednesday=3, Thursday=4 }

        public static string title = "C# Essential Training";
        public static int whichPart;

        static void Main(string[] args)
        {
            whichPart = 2;
            /*var message = string.Format("this is the {0} part {1}", title, whichPart);
            Console.WriteLine(message);
            Console.WriteLine("Press the enter key to exit.");
            Console.ReadLine();

            Console.WriteLine(int.Parse("15"));
            Console.WriteLine("xyz".ToUpper());
            var testString = " abCDefg  ";
            Console.WriteLine(testString.Trim());
            Console.WriteLine(testString.TrimStart());
            Console.WriteLine(testString.TrimEnd());
            var password = "P@ssw0rd";
            password.ToLower();
            password.ToUpper();
            var dickens = "It was the best times, it was the worst times.";
            dickens.Substring(4,8);
            Console.WriteLine(dickens.Substring(4, 8));
            Console.WriteLine(dickens.Length);
            var challenge = "   Text processing in C# is really great!  ";
            Console.WriteLine(challenge.Trim().Length - 25);
            Console.WriteLine(challenge.Trim().Substring(24,challenge.Trim().Length - 25).ToUpper());
            var sb = new System.Text.StringBuilder();
            sb.Append("It was the best of times, it was the worst of times.");
            sb.Append(" it was the age of wisdom,");
            sb.Append(" it was the age of foolishness");
            Console.WriteLine(sb);
            sb.ToString();
            Console.WriteLine(sb.ToString());
                      
            var city = "Atlanta";
            var temperature = 6109.4f;//f means float
            var currentDt = DateTime.Now;
            Console.WriteLine("Welcome to {0}. Time is {1:T}. Temperature is {2:0,000.00}.", city, currentDt, temperature);

            Console.WriteLine(int.Parse("15,234,822,33".Replace(",","")));
            int result;
            Console.WriteLine(int.TryParse("15,234",out result));
            Console.WriteLine(result);
            Console.WriteLine(float.TryParse("11",out float result1));
            Console.WriteLine(long.TryParse("22",out long result2));
                       
            Console.WriteLine(5 + 5);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 % 2);

            int test = 5;
            Console.WriteLine(test++);
            Console.WriteLine(test);
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Round(2.4));
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(3.5));

            const float pi = 3.14f;
            Console.WriteLine(pi);
            var someDay = weekdays.Wednesday;
            Console.WriteLine(someDay);
            */
            Console.WriteLine(DateTime.Now);
            var birthday = new DateTime(1991, 10, 21);
            var difference = DateTime.Now - birthday;
            Console.WriteLine(difference);
            Console.WriteLine(difference.Days);
            Console.WriteLine(difference.Days / 365);
            var someTime = new DateTime(2018, 12, 29, 8, 9, 38);
            Console.WriteLine(someTime.AddMinutes(134));
            Console.WriteLine(someTime.AddMinutes(-50));




        }
    }
}
