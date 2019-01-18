﻿using System;
using System.IO;

namespace MSCourse.ModuleThreeLab1
{
    public class GCTest
    {

        public void GCDemo()
        {
            StreamReader streamReaderObject = null;
            try
            {
                // Assigns "streamReaderObject" to read from a text file named "file1"
                streamReaderObject = new StreamReader("file1.txt");

                // Reads all characters from the current position to the end of the stream
                // Stores in String variable "contents"
                String contents = streamReaderObject.ReadToEnd();


                // Writes the amount of text elements in the text file to the Console
                Console.WriteLine("The file has {0} text elements.", contents.Length);
            }

            // Code to handle any errors
            catch (FileNotFoundException)
            {
                // Informs user there is no file created
                Console.WriteLine("The file cannot be found.");
            }

            // Invoking the Dispose method in a finally block
            // Note that code in finally block will always execute
            finally
            {
                // Checks if object is not null
                if (streamReaderObject != null)
                {
                    // Closes StreamReader
                    streamReaderObject.Close();

                    // Calls upon the Dispose method
                    // Releases all resources used by the TextReader object
                    streamReaderObject.Dispose();
                }
                Console.WriteLine("GCDemo finished.");
            }
        }
    }
}
