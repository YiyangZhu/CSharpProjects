using System;
using System.IO;
using System.Net;

namespace WebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            //way 1 - using WebRequest
            WebRequest request = WebRequest.Create("http://www.google.com");
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            string html = String.Empty;
            using (StreamReader sr = new StreamReader(data))
            {
                html = sr.ReadToEnd();
                Console.WriteLine(html);
            }


            //way 2 - using WebClient
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://www.gooogle.com");
            Console.WriteLine(downloadString);

        }
    }
}
