using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class My_listing_addController : Controller
    {
		private readonly RealEstateContext _context;

		public My_listing_addController(RealEstateContext context)
		{
			_context = context;
		}		

		public IActionResult Index(string title, string type, string price, string bedrooms, string bathrooms, string area, string location, string address, string locality, string state, string country, string postal_code, string Garden, string Gym, string Internet, string Pool, string Window, string Parking, string School, string Bank, string Metro, string Airport, string propertyDescription, List<IFormFile> galleries, string featured)
        {

			if(!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(price) && !String.IsNullOrEmpty(propertyDescription))
			{
				object property = new Property { Description = title, Type = type, Price = price, Location = location, TotalBed = 3, TotalShower = 2,
					SquareFeet = "1000", //area
					ListedOn = DateTime.Now.ToShortDateString(), ListedBy = "Admin", Image = "4.jpg", Lat = 3.06460900000000M, Lng = 3.06460900000000M };
				_context.Add(property);
				_context.SaveChanges();

				//TODO : shows popup successfully added into db!! 
			}			

			return View();
        }
    }
}