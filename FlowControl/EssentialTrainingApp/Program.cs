using System;
using System.Collections.Generic;
using System.IO;
using NLog;


namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;

        static void Main(string[] args)
        {
            logger.Trace("The program started.");
            Words = new List<string>();
            Words.Add("bread");
            Words.Add("Milk");
            Words.Add("Cheese");
            ReadTextFile();

            }

        private static void ReadTextFile()
        {
            try
            {
                using(var sr = new StreamReader(@"c\tmp"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (System.IO.FileLoadException ex)
            {
                Console.WriteLine("could not load the file.");
                logger.Error("cannot load file " + ex.Message);
            } catch(Exception ex)
            {
                Console.WriteLine("an unknown error occurred " + ex.Message);
                logger.Error(ex.Message);
            }
            finally
            {
                Console.WriteLine("The finally runs all the time");
            }
        }

        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i >= 0; i--)
            {
                income = income = income / i;
            }
            return income;
        }
    }
}
