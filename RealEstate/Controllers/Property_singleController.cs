﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class Property_singleController : Controller
    {
        public IActionResult Index(string id)
        {
            return View();
        }
    }
}