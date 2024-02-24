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
            ViewBag.Categories = _context.Categories
                .OrderBy(x=> x.CategoryName)
                .ToList();

            return View("MovieForm", new Movie()); //maybe
        }

        [HttpPost]
        public IActionResult MovieForm(Movie response) //add record to the database
        {
            if(ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation", response);
            }
             else //invalid data
            {

                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
                return View(response);

            }
            
        }

        public IActionResult WaitList()
        {
           
            var movies = _context.Movies //change this to new one if needed 
               .Where(x => x.Edited == false)
               .OrderBy(x => x.Title).ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
           var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName) 
                .ToList();

            return View("MovieForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) 
        {
            _context.Update(updatedInfo); 
            _context.SaveChanges();

            return RedirectToAction("WaitList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies 
               .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie application) 
        {
            _context.Movies.Remove(application); //hereeee
            _context.SaveChanges();

            return RedirectToAction("WaitList");
        }

    }
}
