using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
        public IActionResult CallGreet() 
        { 
            return View(); 
        }
        public IActionResult jQueryCallGreet()
        {
            return View();
        }
		public IActionResult EmployeeManage()
		{
			return View();
		}
		public IActionResult CallCkeckName()
        {
            return View();
        }
        public IActionResult jQueryCallCkeckName()
        {
            return View();
        }
    }
}