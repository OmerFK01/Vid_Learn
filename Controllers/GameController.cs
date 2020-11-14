using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vid_Learn.Models;
using Vid_Learn.ViewModels;

namespace Vid_Learn.Controllers
{
    public class GameController : Controller
    {
        // GET: Person
        public ActionResult Random()
        {
            var game = new Game() { Name = "Call of Duty" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer1"},
                new Customer { Name = "Customer2"}
            };

            var viewModel = new RandomGameViewModel
            {
                Game = game,
                Customers = customers

            };
            //ViewData["Game"] = game;
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();

            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

        }

        [Route("games/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);

        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //games
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy)); 
        }

    }
}