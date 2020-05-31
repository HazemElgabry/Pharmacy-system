using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pharmacy_System.Models;

namespace Pharmacy_System.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        /* /////////////////////////////////////////
         * //////////  Admin Dashboard  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Admin_Dashboard()
        {
            return View();
        }

        /* /////////////////////////////////////////
         * //////////  Admin Profile  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Admin_Profile(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }

            return View(admin);


        }
        [HttpPost]
        public ActionResult Admin_Profile(Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Show_Admins");
            }

            return View(admin);


        }


        /* /////////////////////////////////////////
         * //////////  Show Admins  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Show_Admins()
        {
            return View(db.Admins.ToList());
        }

        /* /////////////////////////////////////////
         * //////////  Add Admins  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Add_Admins()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add_Admins(Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Admins.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Show_Admins");
            }

            return View(admin);
        }
        /* /////////////////////////////////////////
         * //////////  Edit Admins  ///////////
         * ///////////////////////////////////////        
         */
        [HttpGet]
        public ActionResult Edit_Admin(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }

            return View(admin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_Admin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Show_Admins");
            }

            return View(admin);

        }

        public ActionResult Delete_Admin(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            db.Admins.Remove(admin);
            
            db.SaveChanges();
            return RedirectToAction("Show_Admins");

        }
       
        /* /////////////////////////////////////////
         * //////////  Show Customers  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Show_Customers()
        {
            return View(db.Customers.ToList());
        }

        /* /////////////////////////////////////////
         * //////////  Add Customer  ///////////
         * ///////////////////////////////////////        
         */

        public ActionResult Add_Customers()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add_Customers(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Show_Customers");
            }
            return View(customer);
        }

        /* /////////////////////////////////////////
         * //////////  Edit Customers  ///////////
         * ///////////////////////////////////////        
         */
        [HttpGet]
        public ActionResult Edit_customer_as_Admin(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_customer_as_Admin(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Show_Customers");
            }

            return View(customer);

        }

        public ActionResult Delete_customer_as_Admin(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Show_Customers");

        }

        /* /////////////////////////////////////////
           * //////////  Show Medicine  ///////////
           * ///////////////////////////////////////        
           */

        public ActionResult Show_Medicine(string search)
        {

            return View(db.Medicines.Where(x => x.name.Contains(search) || search == null).ToList());


        }


        /* /////////////////////////////////////////
         * //////////  Add Medicine  ///////////
         * ///////////////////////////////////////        
         */
        public ActionResult Add_Medicine()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add_Medicine(Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                db.Medicines.Add(medicine);
                db.SaveChanges();
                return RedirectToAction("Show_Medicine");
            }

            return View(medicine);
        }
        /* /////////////////////////////////////////
         * //////////  Edit Medicine  ///////////
         * ///////////////////////////////////////        
         */

        [HttpGet]
        public ActionResult Edit_admin_medicine(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Medicine medicine = db.Medicines.Find(id);
            if (medicine == null)
            {
                return HttpNotFound();
            }

            return View(medicine);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_admin_medicine(Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Show_Medicine");
            }

            return View(medicine);

        }



        /* /////////////////////////////////////////
    * //////////  Delete Medicine  ///////////
    * ///////////////////////////////////////        
    */
        public ActionResult Delete_admin_medicine(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medicine medicine = db.Medicines.Find(id);
            if (medicine == null)
            {
                return HttpNotFound();
            }
            db.Medicines.Remove(medicine);

            db.SaveChanges();
            return RedirectToAction("Show_Medicine");

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