namespace CommandDemo
{
    public class EmailMessageCommand : IMessageCommand
    {
        private Message msg;
        public EmailMessageCommand (Message msg)
        {
            this.msg = msg;
        }
        public void DoAction()
        {
            msg.EmailMessage();
        }
    }
}