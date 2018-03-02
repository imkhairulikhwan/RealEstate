using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class Property_listing_mapController : Controller
    {
		private readonly RealEstateContext _context;
		private string _propertyArea;
		private string _propertyType;

		public Property_listing_mapController(RealEstateContext context)
		{
			_context = context;
		}

		public IActionResult Index(string searchin, string propertyArea, string propertyType)
		{
			//_propertyArea = (String.IsNullOrEmpty(propertyArea) ? "" : propertyArea);
			//_propertyType = (String.IsNullOrEmpty(propertyType) ? "" : propertyType);
			List<Property> listProperty;
			
			listProperty = _context.Property.Where(a => (String.IsNullOrEmpty(propertyArea) || a.Location.Contains(propertyArea)) && (String.IsNullOrEmpty(propertyType) || a.Type.Contains(propertyType))).ToList();
			var listAgent = _context.Agent.ToList();

			return View();
        }
    }
}