using System;
using System.Linq;
namespace CommandDemo
{
    public class Message
    {
        public string CustomMessage{get;set;}
        public void EmailMessage()
        {
            Console.WriteLine($"{CustomMessage} : Email Message sent");
        }
        public void SmsMessage()
        {
            Console.WriteLine($"{CustomMessage} : sms Message sent");
        }
    }
}