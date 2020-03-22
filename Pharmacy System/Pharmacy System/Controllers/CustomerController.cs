using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pharmacy_System.Models;
using System.Data.Entity;
using Pharmacy_System.Context;


namespace Pharmacy_System.Controllers
{
    public class CustomerController : Controller
    {
        private customersContext db = new customersContext();

        // GET: User/Registration
        [HttpGet]
        public ActionResult Registration()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer use)
        {
            if (ModelState.IsValid)
            {
                db.customer.Add(use);
                db.SaveChanges();
                return View("Done");
            }
            else
                return View("Error");
        }
    }
}