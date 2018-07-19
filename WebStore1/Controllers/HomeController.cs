using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore1.Models;

namespace WebStore1.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult CheckOut()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult BlogList()
        {
            return View();
        }
        public IActionResult BlogSingle()
        {
            return View();
        }
        public IActionResult NotFound()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}