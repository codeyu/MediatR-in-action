using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace demo1
{
    public class NewUserHandler : IRequestHandler<NewUser, bool>
    {
        public Task<bool> Handle(NewUser request, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }

        
    }
}