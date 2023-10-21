using CustomHTMLHelperInCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomHTMLHelperInCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            Employee employee = new Employee()
            {
                Id = 106724,
                FullName = "Pranaya Rout",
                Designation = "Manager",
                Department = "IT",
                Photo = "/Images/User.webp",
                AlternateText = "Pranaya Rout Photo Not Available"
            };
            return View(employee);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}