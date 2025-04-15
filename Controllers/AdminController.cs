using Microsoft.AspNetCore.Mvc;

namespace PrimeMarket.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminLogin()
        {
            return View();
        }
        public IActionResult AdminDashboard()
        {
            return View();
        }
    }
}
