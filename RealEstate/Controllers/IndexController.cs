using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index(string name)
        {
            //username is taken from the login provider e.g. Facebook, Gmail
            return View(new SignInViewModel() { Name = name });
        }
    }    
}