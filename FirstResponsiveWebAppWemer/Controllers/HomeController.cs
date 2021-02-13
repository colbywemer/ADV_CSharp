using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppWemer.Models;
namespace FirstResponsiveWebAppWemer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = null;
            ViewBag.Age = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(AgeCalculartor model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.AgeThisYear();
                ViewBag.Name = model.Name;
            }
            else
            {
                ViewBag.Age = 0;
                ViewBag.Name = null;
            }
            return View(model);
        }
        
    }
}
