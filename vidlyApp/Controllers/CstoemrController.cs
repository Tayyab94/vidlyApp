using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidlyApp.DataViewModel;
using vidlyApp.Models;
using System.Data.Entity;

namespace vidlyApp.Controllers
{
    public class CstoemrController : Controller
    {
        private DemoContext _context = new DemoContext();
        public CstoemrController()
        {
            _context = new DemoContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Cstoemr


            public ActionResult Index()
        {
            var cus = _context.cutomers.Include(x => x.MemberShiptype).ToList();
            return View(cus);
        }

        [HttpGet]
        public ActionResult New()
        {
            var MenberShiplist = _context.MemberShipTypes.ToList();
            // ViewBag.MemBerList = MenberShiplist;
            var NewcustomerViewList = new NewCustomerViewModel
            {
                MemberShiptypes = MenberShiplist
            };
            return View("CustomerForm", NewcustomerViewList);
           // return View();

        }

        [HttpPost]
        public ActionResult AddCurtomers(Customer obj)
        {
        
            if(obj.Id==0)
            {

                _context.cutomers.Add(obj);
               
            }
            else
            {
                var customer = _context.cutomers.Single(x => x.Id == obj.Id);
                customer.Name = obj.Name;
                customer.BithDate = obj.BithDate;
                customer.MemberShiptype = new MemberShiptype { Id = Convert.ToInt32(obj) };
                customer.IsSubscribeToNewsletter = obj.IsSubscribeToNewsletter;
                _context.cutomers.Add(customer);
            }
            _context.SaveChanges();

            return RedirectToAction("New");
        }

        public ActionResult Edit(int id)
        {
            Customer objCus = _context.cutomers.SingleOrDefault(a => a.Id == id);
            if (objCus == null)
            {
                return HttpNotFound();
            }

            var ViewModel = new NewCustomerViewModel
            {
                Customer = objCus,
                MemberShiptypes = _context.MemberShipTypes.ToList()
        };
            return View("CustomerForm", ViewModel);
        }
    }
}