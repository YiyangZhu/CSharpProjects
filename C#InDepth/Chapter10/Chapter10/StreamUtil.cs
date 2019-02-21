using System;
using System.IO;
using System.Net;

namespace Chapter10
{
    public static class StreamUtil
    {
        const int BufferSize = 8192;

        public static void Copy(Stream input, Stream output)
        {
            byte[] buffer = new byte[BufferSize];
            int read;
            while((read = input.Read(buffer, 0, buffer.Length)) > 0){
                output.Write(buffer, 0, read);
                Console.WriteLine(read);
            }
        }

        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream tempStream = new MemoryStream())
            {
                Copy(input, tempStream);
                return tempStream.ToArray();
            }
        }

        public static void Demo()
        {
            WebRequest request = WebRequest.Create("http://manning.com");
            using (WebResponse response = request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (FileStream output = File.Create("response.dat"))
            {
                StreamUtil.Copy(responseStream, output);
            }
        }

        public static void Demo2()
        {
            WebRequest request = WebRequest.Create("http://manning.com");
            using (WebResponse response = request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (FileStream output = File.Create("response.dat"))
            {
                responseStream.CopyTo(output);
            }
        }

        public static void CopyTo(this Stream input, Stream output)
        {
            byte[] buffer = new byte[BufferSize];
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }
        public static byte[] ReadFully2(this Stream input)
        {
            using (MemoryStream tempStream = new MemoryStream())
            {
                CopyTo(input, tempStream);
                return tempStream.ToArray();
            }
        }
    }


}
