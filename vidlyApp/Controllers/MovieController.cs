using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using vidlyApp.Models;

namespace vidlyApp.Controllers
{
    public class MovieController : Controller
    {
        private DemoContext _Context;

        public MovieController()
        {
            _Context = new DemoContext();
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();   
        }
        // GET: Movie
        public ActionResult Index(Customer o)
        {
            DemoContext _context = new DemoContext();
            var moviesList = _context.Movies.Include(a => a.Genre).ToList();

            return View(moviesList);

        }

        [HttpGet]
        public ActionResult Index1()
        {
       
           
            return View();
        }

        [HttpPost]
        public ActionResult Index1(Customer o)
        {
            DemoContext _context = new DemoContext();
            Customer oa = new Customer();
            oa.Name = o.Name;
           
            _context.Cuttomers.Add(oa);
            _context.SaveChanges();

            return View();

        }

        public ActionResult Details(int id)
        {
            var MovieDetail = _Context.Movies.Include(x => x.Genre).SingleOrDefault(x => x.Id == id);
            return View(MovieDetail);
        }
    }
}