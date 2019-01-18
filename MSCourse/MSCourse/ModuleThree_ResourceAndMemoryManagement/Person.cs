using System;
using System.IO;

namespace MSCourse.ModuleThree_ResourceAndMemoryManagement
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        private bool disposed = false;
        StreamReader sr;
        StreamWriter outputFile;
        
        public void ReadDetails(string fileName)
        {
            sr = new StreamReader(fileName);
            try
            {
                using (sr)
                {
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
                sr = null;
            }
        }

        public bool WriteDetails(string fileName)
        {
            bool result = false;
            outputFile = new StreamWriter(fileName);

            string[] lines = { this.PersonID.ToString(), this.FirstName, this.LastName, this.Gender, this.Age.ToString() };

            try
            {
                using (outputFile)
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                    
                }
                result = true;
            }
            catch(Exception e)
            {
                Console.WriteLine("This file could not be written");
                Console.WriteLine(e.Message);
                result = false;
            }
            finally
            {
                outputFile.Close();
                outputFile = null;
            }

            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if(sr != null)
                    {
                        sr.Close();
                    }
                    if(outputFile != null)
                    {
                        outputFile.Close();
                    }
                }
            }
            disposed = true;
        }

    }
}
