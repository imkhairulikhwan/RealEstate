using Microsoft.AspNetCore.Mvc.Rendering;

namespace RealEstate.Models
{
    public class UserProfileViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string AboutMe { get; set; }
        public string AgentCompanyTitle { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDateMonth { get; set; }
        public string ExpirationDateYear { get; set; }
        public int SecurityCode { get; set; }        
        public SelectList ExpirationDateMonthList { get; set; }
        public SelectList ExpirationDateYearList { get; set; }
    }
}
