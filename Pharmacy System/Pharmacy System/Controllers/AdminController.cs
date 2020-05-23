using Pharmacy_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pharmacy_System.Controllers
{
    public class AdminController : Controller
    {
        /* /////////////////////////////////////////
         * //////////  Admin Dashboard  ///////////
         * ///////////////////////////////////////        
         */
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Admin_Dashboard()
        {
            return View();
        }

        /* /////////////////////////////////////////
         * //////////  Admin Profile  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Admin_Profile()
        {
            return View();
        }

        /* /////////////////////////////////////////
         * //////////  Show Admins  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Show_Admins()
        {
            return View();
        }

        /* /////////////////////////////////////////
         * //////////  Add Admins  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Add_Admins()
        {
            return View();
        }

        /* /////////////////////////////////////////
         * //////////  Show Customers  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Show_Customers()
        {
            return View();
        }

        /* /////////////////////////////////////////
         * //////////  Add Customer  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Add_Customers()
        {
            return View();
        }

        /* /////////////////////////////////////////
         * //////////  Show Medicine  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Show_Medicine()
        {
            var med = db.Medicines;
            return View(med.ToList());
        }

        /* /////////////////////////////////////////
         * //////////  Add Medicine  ///////////
         * ///////////////////////////////////////        
         */
        [HttpGet]
        public ActionResult Add_Medicine()
        {
            Medicine med = new Medicine();
            return View(med);
        }
        [HttpPost]
        public ActionResult Add_Medicine(Medicine med)
        {
            db.Medicines.Add(med);
            db.SaveChanges();
            return RedirectToAction("Add_Medicine");
        }

        /* /////////////////////////////////////////
         * //////////  Show News  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Show_News()
        {
            return View();
        }

        /* /////////////////////////////////////////
         * //////////  Add News  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Add_News()
        {
            return View();
        }
    }
}