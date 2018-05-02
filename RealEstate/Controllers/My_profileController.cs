using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class My_profileController : Controller
    {
        UserProfileViewModel userProfile = new UserProfileViewModel();
        private readonly RealEstateContext _context;

        public My_profileController(RealEstateContext context)
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

            return View(userProfile);
        }

        [HttpPost]
        public IActionResult UpdateProfile(UserProfileViewModel data)
        {
            var loggedinUser = _context.User.Where(a => a.Email == User.Identity.Name).FirstOrDefault();

            _context.Attach(loggedinUser);            
            _context.Entry(loggedinUser).Property("FirstName").IsModified = true;
            _context.Entry(loggedinUser).Property("FirstName").CurrentValue = data.FirstName;
            _context.Entry(loggedinUser).Property("LastName").IsModified = true;
            _context.Entry(loggedinUser).Property("LastName").CurrentValue = data.LastName;
            _context.Entry(loggedinUser).Property("Email").IsModified = true;
            _context.Entry(loggedinUser).Property("Email").CurrentValue = data.Email;
            _context.Entry(loggedinUser).Property("Address").IsModified = true;
            _context.Entry(loggedinUser).Property("Address").CurrentValue = data.Address;
            _context.Entry(loggedinUser).Property("CompanyTitle").IsModified = true;
            _context.Entry(loggedinUser).Property("CompanyTitle").CurrentValue = data.AgentCompanyTitle;
            _context.Entry(loggedinUser).Property("AboutMe").IsModified = true;
            _context.Entry(loggedinUser).Property("AboutMe").CurrentValue = data.AboutMe;
            _context.Entry(loggedinUser).Property("City").IsModified = true;
            _context.Entry(loggedinUser).Property("City").CurrentValue = data.City;
            _context.Entry(loggedinUser).Property("State").IsModified = true;            
            _context.Entry(loggedinUser).Property("State").CurrentValue = data.State;
            _context.Entry(loggedinUser).Property("Zipcode").IsModified = true;
            _context.Entry(loggedinUser).Property("Zipcode").CurrentValue = data.Zipcode;
            _context.Entry(loggedinUser).Property("Country").IsModified = true;
            _context.Entry(loggedinUser).Property("Country").CurrentValue = data.Country;
            var sucess = _context.SaveChanges();

            return View(new ReturnData() { Message = "Successfully saved the record"});
        }
    }

    public class ReturnData
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}