using Microsoft.AspNetCore.Mvc;
using Mission06_DoLago.Models;
using System.Diagnostics;

namespace Mission06_DoLago.Controllers
{
    public class HomeController : Controller
    {
        private FormApplicationContext _context;
        public HomeController(FormApplicationContext temp) 
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View("GetToKnowJoel");
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult MovieForm(Form response)
        {
            _context.Forms.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
