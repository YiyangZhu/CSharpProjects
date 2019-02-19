using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Chapter9
{
    public class ExpressionTree
    {
        public ExpressionTree()
        {
        }

        public static void Demo()
        {
            Expression<Func<int>> return5 = () => 5; 
            Func<int> compiled = return5.Compile(); 
            Console.WriteLine(compiled());


        }

        public static void Demo2()
        {
            Expression<Func<string, string, bool>> expression = (x, y) => x.StartsWith(y);
            var compiled = expression.Compile();
            Console.WriteLine(compiled("First", "Second"));
            Console.WriteLine(compiled("First", "Fir"));
        }

        public static void Demo3()
        {
            MethodInfo method = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });
            var target = Expression.Parameter(typeof(string), "x");
            var methodArg = Expression.Parameter(typeof(string), "y");
            Expression[] methodArgs = (Expression[])(new[] { methodArg });

            Expression call = Expression.Call(target, method, methodArgs);
            var lambdaParameters = new[] { target, methodArg };
            var lambda = Expression.Lambda<Func<string, string, bool>>(call, lambdaParameters);
            var compiled = lambda.Compile();
            Console.WriteLine(compiled("First", "Second"));
            Console.WriteLine(compiled("First", "Fir"));

        }

    }
}
