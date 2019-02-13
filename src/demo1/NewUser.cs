using MediatR;

namespace demo1
{
    public class NewUser: IRequest<bool>
    {
        public string Username {get;set;}
        public string Password {get;set;}
    }
}