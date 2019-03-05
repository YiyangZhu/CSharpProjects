using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter15
{
    public class Asyn
    {
        private static string url;

        public Asyn()
        {
        }

        public async Task<int> FooAsync()
        {
            string bar = await BarAsync();
            return bar.Length;
        }

        private Task<string> BarAsync()
        {
            throw new NotImplementedException();
        }

        static async Task<int> GetPageLengthAsync(string url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            using (HttpClient client = new HttpClient())
            {
                Task<string> fetchTextTask = client.GetStringAsync(url);
                int length = (await fetchTextTask).Length;
                return length;
            }
        }


        public static async Task DemoAsync()
        {
            string pageText = await new HttpClient().GetStringAsync(url);
        }

        string FetchFirstSuccessful(IEnumerable<string> urls)
        {
            foreach (string url in urls)
            {
                try
                {
                }
                catch (WebException exception)
                {
                }
            }
            throw new WebException("No URLs succeeded");
        }


    }
}
