using System;
namespace Chapter13
{
    public class Message
    {
        string m;
        public Message(string from, string to, string body, string subject = null, byte[] attachment = null)
        {
            this.m = "from: " + from + "\nto: "+to +"\nbody: "+body+ "\nsubject: " + subject;
        }

        public static void Demo()
        {
            Message message = new Message(from: "ererandkeke@gmail.com", to: "wangkekekexili@gmail.com", body: "happy birthday, darling!", subject: "A quick message");
            Console.Write(message);
        }

        public override string ToString()
        {
            return m;
        }
    }
}
