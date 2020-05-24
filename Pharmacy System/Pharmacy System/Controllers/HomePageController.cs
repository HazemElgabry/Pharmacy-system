using Pharmacy_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pharmacy_System.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Login_Register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var customers = db.Customers.Where(n => n.email_address == customer.email_address).Single();
                    if (customers != null)
                    {

                        return Json(new { result = 0 });
                    }
                }
                catch
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    return Json(new { result = customer.id });
                }
            }
            return Json(new { result = -1 });
        }
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(Customer customer)
        {
            try
            {
                var customers = db.Customers.Where(n => n.email_address == customer.email_address && n.password == customer.password).Single();
                if (customers != null)
                {
                    Session["user_id"] = customers.id;
                    return Json(new { result = customers.id });
                    //return View("Profile", db.Customers.Find(customers.id));
                }
            }
            catch
            {
                try
                {
                    var Admin = db.Admins.Where(n => n.email_address == customer.email_address && n.password == customer.password).Single();
                    if (Admin != null)
                    {
                        //ViewBag.id = Admin.id;
                        Session["user_id"] = Admin.id;

                        return Json(new { result = 0 ,id= Admin.id });
                    }
                }
                catch
                {
                    return Json(new { result = -1 });
                }

            }
            return Json(new { result = -1 });
        }
    }
}