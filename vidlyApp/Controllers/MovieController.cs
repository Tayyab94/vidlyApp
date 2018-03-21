using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidlyApp.Models;

namespace vidlyApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        [HttpGet]
        public ActionResult Index()
        {
       
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer o)
        {
            DemoContext _context = new DemoContext();
            Customer oa = new Customer();
            oa.Name = o.Name;
           
            _context.Cuttomers.Add(oa);
            _context.SaveChanges();

            return View();

        }

        public ActionResult Eid(int id)
        {
            if(id==0)
            {
                id = 2;
            }
            return Content(id.ToString());
        }
    }
}