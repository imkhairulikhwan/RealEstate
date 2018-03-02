﻿using System;
using System.Collections.Generic;

namespace RealEstate.Models
{
    public partial class Property
	{
        public int Id { get; set; }
        public string Description { get; set; }
		public string Location { get; set; }
		public int TotalBed { get; set; }
		public int TotalShower { get; set; }
		public string SquareFeet { get; set; }
		public string Type { get; set; }
		public string ListedOn { get; set; }
		public string ListedBy { get; set; }		
    }
}