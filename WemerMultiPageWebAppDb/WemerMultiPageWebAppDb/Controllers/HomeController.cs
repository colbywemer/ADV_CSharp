using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WemerMultiPageWebAppDb.Models;
using Microsoft.EntityFrameworkCore;

namespace WemerMultiPageWebAppDb.Controllers
{
    public class HomeController : Controller
    {
        private ContactsContext context { get; set; }
        public HomeController(ContactsContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(m => m.Name).ToList();
            return View(contacts);
        }
    }
}
