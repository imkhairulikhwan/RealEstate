﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class CompareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}