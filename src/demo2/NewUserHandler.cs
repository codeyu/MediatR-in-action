using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
namespace demo2
{
    public class NewUserHandler : INotificationHandler<NewUser>  
    {  
        public Task Handle(NewUser notification, CancellationToken cancellationToken)  
        {  
            //Save to log  
            Debug.WriteLine(" ****  Save user in database  *****");  
            return Task.FromResult(true);  
        }  
    }  
}