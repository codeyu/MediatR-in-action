using System;

namespace CommandDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            msg.CustomMessage = "Welcome by Email";
            EmailMessageCommand emailMsgCommand = new EmailMessageCommand(msg);

            Message msg2 = new Message();
            msg2.CustomMessage = "Welcome by Sms";
            SmsMessageCommand smsMsgCommand = new SmsMessageCommand(msg2);
            Broker broker = new Broker();
            broker.SendMessage(emailMsgCommand);
            broker.SendMessage(smsMsgCommand);
            Console.ReadKey();
        }
    }
}
