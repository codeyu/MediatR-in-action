namespace CommandDemo
{
    public class SmsMessageCommand : IMessageCommand
    {
        private Message msg;
        public SmsMessageCommand (Message msg)
        {
            this.msg = msg;
        }
        public void DoAction()
        {
            msg.SmsMessage();
        }
    }
}