using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidlyApp.Models;
using System.Data.Entity;

namespace vidlyApp.Controllers
{
    public class CustomerController : Controller
    {
        private DemoContext _context;
       public CustomerController()
        {
            _context = new DemoContext();
        }


        //Dispose the Object 
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var Customer = _context.Cuttomers.Include(a=>a.MemberShiptype).ToList();
            return View(Customer);
        }


        public ActionResult Details(int id)
        {
            var customer = _context.Cuttomers.Include(a=>a.MemberShiptype).SingleOrDefault(c => c.Id == id);
            if(customer==null)
            {
                return HttpNotFound();  
            }

            return View(customer);
        }




        //THis Method was use just Hard coded Data Enter 
      //private IEnumerable<Customer> GetCustomers()
      //  {
      //      return new List<Customer>
      //      {
      //          new Customer{ Id=1,Name="Tayyab"},
      //          new Customer{Id=2, Name="Usame"}
      //      };
      //  }
    }
}