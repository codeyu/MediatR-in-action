using MediatR;
namespace demo2
{
    public class NewUser : INotification
    {
        public string Username { get; set; }  
        public string Password { get; set; }  
    }
}