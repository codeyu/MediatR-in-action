using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
namespace demo2
{
    public class EmailHandler : INotificationHandler<NewUser>  
    {  
        public Task Handle(NewUser notification, CancellationToken cancellationToken)  
        {  
            //Send email  
            Debug.WriteLine(" ****  Email sent to user  *****");  
            return Task.FromResult(true);  
        }  
    }  
}