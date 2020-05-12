using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HIMS_Web.Models;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Http;

namespace HIMS_Web.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ILogger<HomeController> Logger => _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {

            ViewData["用户名"] = Request.Cookies["name"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("name");
            return RedirectToAction("Index", "Login");
        }
    }
}
