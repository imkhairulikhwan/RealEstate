﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class My_bookmarked_listingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}