using sept14_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sept14_2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>();
            for(int i = 1; i <= 10; i++) {
                genres.Add(new Genre { Name = "Genre " + i.ToString() });
            }
            return View(genres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            ViewBag.Genre = genre;
            return View();
        }
    }
}