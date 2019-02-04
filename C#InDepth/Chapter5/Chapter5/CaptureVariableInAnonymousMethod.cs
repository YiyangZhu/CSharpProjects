using System;
namespace Chapter5
{
    public class CaptureVariableInAnonymousMethod
    {
        public CaptureVariableInAnonymousMethod()
        {
        }

        public static void Demo()
        {
            EnclosingMethod();
        }

        public static void EnclosingMethod()
        {
            int outerVariable = 5;
            string captureVariable = "captured";

            if(DateTime.Now.Hour == 23)
            {
                int normalLocalVariable = DateTime.Now.Minute;
                Console.WriteLine(normalLocalVariable);
            }

            Action x = delegate ()
            {
                string anonLocal = "local to anonymous method";
                Console.WriteLine(captureVariable + anonLocal);
            };
            x();

            string yCaptured = "before y is created";
            Console.WriteLine(yCaptured);
            Action y = delegate ()
            {
                string anonLocal = "local to anonymous method";
                Console.WriteLine(captureVariable + anonLocal);
            };
            yCaptured = "right before y is invocated";
            Console.WriteLine(yCaptured);
            y();
            yCaptured = "right after y is invocated";
            Console.WriteLine(yCaptured);

            y();
            yCaptured = "right after y's second invocation";
            Console.WriteLine(yCaptured);

        }
    }
}
