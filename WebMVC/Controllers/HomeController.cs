using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMVC.Models;

namespace WebMVC.Controllers
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

        public IActionResult BeginningData()
        {
            var beginningData = new[]
            {
                new { Id = 98, Name = "AB inner plastic bones of hearing - beginning data 98", GithubAddress = "https://github.com/Tboy1989/TestWebMVC2566" },
                new { Id = 99, Name = "AB inner plastic bones of hearing - beginning data 99", GithubAddress = "https://github.com/Tboy1989/TestWebMVC2566" }
            };

            return View(beginningData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Test()
        {
            return View();
        }

    }
}
