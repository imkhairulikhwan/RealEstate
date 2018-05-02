using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class My_paymentsController : Controller
    {
        UserProfileViewModel userProfile = new UserProfileViewModel();
        private readonly RealEstateContext _context;

        public My_paymentsController(RealEstateContext context)
        {
            _context = context;
        }

        public IActionResult Index(string user)
        {
            var loggedinUser = _context.User.Where(a => a.Email == user || a.Email == User.Identity.Name).FirstOrDefault();

            userProfile.FirstName = loggedinUser.FirstName;
            userProfile.LastName = loggedinUser.LastName;
            userProfile.Email = loggedinUser.Email;
            userProfile.AboutMe = loggedinUser.AboutMe;
            userProfile.CardNumber = loggedinUser.CardNumber;
            userProfile.ExpirationDateMonth = loggedinUser.ExpirationDateMonth;
            userProfile.ExpirationDateYear = loggedinUser.ExpirationDateYear;
            userProfile.SecurityCode = loggedinUser.SecurityCode;

            var months = new List<string>();
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");

            var years = new List<string>();
            years.Add("2015");
            years.Add("2016");
            years.Add("2017");
            years.Add("2018");
            years.Add("2019");
            years.Add("2020");
            years.Add("2021");
            years.Add("2022");
            years.Add("2023");
            years.Add("2024");
            years.Add("2025");
            years.Add("2026");
            years.Add("2027");
            years.Add("2028");
            years.Add("2029");
            years.Add("2030");

            userProfile.ExpirationDateMonthList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(months);
            userProfile.ExpirationDateYearList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(years);

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            

            return View(userProfile);
        }
    }
}