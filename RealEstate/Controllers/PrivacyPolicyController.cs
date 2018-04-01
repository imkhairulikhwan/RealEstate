using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class PrivacyPolicyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}