using Contest.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.Controllers
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
            return View(new HomeViewModel());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View(new HomeViewModel());
        }

        [HttpPost]
        public IActionResult Form(HomeViewModel model)
        {
            System.IO.File.WriteAllText(@"e:\temp.cs", model.Text);
            Process.Start(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe", @"/t:exe temp.cs");
            Process.Start(@"temp.exe");
            Debug.WriteLine(model.Text);
            return View("Success");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
