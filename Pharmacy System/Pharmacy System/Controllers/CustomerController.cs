using Pharmacy_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pharmacy_System.Controllers
{
    public class CustomerController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Customer

        public ActionResult Customer_Dashboard(int id)
        {

            return View();
        }
        public ActionResult Customer_Profile(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        public ActionResult contacts()
        {

            return View();
        }

        public ActionResult Show_Medicine()
        {
            var medicine = db.Medicines.ToList();
            return View(medicine);
        }
        [HttpGet]
        public ActionResult edit_customer(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        [HttpPost]
        public ActionResult edit_customer(Customer customer)
        {
           
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { result = 1 });
           
        }
    }
}