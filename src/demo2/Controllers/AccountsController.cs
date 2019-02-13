using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demo2.Models;
using MediatR;
namespace demo2.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IMediator _mediator;  
        public AccountsController(IMediator mediator)  
        {  
            _mediator = mediator;  
        }  
        [HttpGet]  
        public ActionResult Login()  
        {  
            return View();  
        }  
        [HttpGet]  
        public ActionResult Register()  
        {  
            return View();  
        }  
  
        [HttpPost]  
        public ActionResult Register(NewUser user)  
        {  
            _mediator.Publish(user);  
            return RedirectToAction("Login");  
        }  
    }
}