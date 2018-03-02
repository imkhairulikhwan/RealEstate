using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class Property_listingController : Controller
    {
        public IActionResult Index(string searchin, string propertyArea, string propertyType)
        {
            return View();
        }
    }
}