﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index(string name, string email, string password, string student)
        {
            return View();
        }
    }
}