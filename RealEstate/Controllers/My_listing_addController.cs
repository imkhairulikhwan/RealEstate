using System;
using System.Collections.Generic;
using System.IO;
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

        public async Task<IActionResult> Index(string title, string type, string price, string bedrooms, string bathrooms, string area, string location, string address, string locality, string state, string country, string postal_code, string Garden, string Gym, string Internet, string Pool, string Window, string Parking, string School, string Bank, string Metro, string Airport, string propertyDescription, List<IFormFile> files, string featured)
        {
            //file upload
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            //var filePath = Path.GetTempFileName();
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            if (!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(price) && !String.IsNullOrEmpty(propertyDescription))
			{
				object property = new Property { Description = title, Type = type, Price = price, Location = location, TotalBed = 3, TotalShower = 2,
					SquareFeet = "1000", //area
					ListedOn = DateTime.Now.ToShortDateString(), ListedBy = "Admin", Image = "4.jpg", Lat = 3.06460900000000M, Lng = 3.06460900000000M };
				_context.Add(property);
				_context.SaveChanges();

                

                // process uploaded files
                // Don't rely on or trust the FileName property without validation.

                //return Ok(new { count = files.Count, size, filePath });

                //TODO : shows popup successfully added into db!! 
            }			

			return View();
        }
    }
}