using System;
using System.Collections.Generic;

namespace RealEstate.Models
{
    public partial class Agent
	{
        public int Id { get; set; }
        public string Name { get; set; }
		public string Location { get; set; }
		public string Description { get; set; }
		public string Profile { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Website { get; set; }
    }
}
