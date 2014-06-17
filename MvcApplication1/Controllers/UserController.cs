using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using WebMatrix.WebData;

namespace MvcApplication1.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            MedicalCasesDataClassesDataContext mcDataContext = new MedicalCasesDataClassesDataContext();
            var userData = from u in mcDataContext.Users
                           select u;
            return View(userData);
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            String currentUserName = WebSecurity.CurrentUserName;
            User model = new User();
            model.userName = currentUserName;
            return View(model);
        }

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult Create(User model)
        //public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                //var username = model.userName;
                MedicalCasesDataClassesDataContext mcDataCtx = new MedicalCasesDataClassesDataContext();
                mcDataCtx.Users.InsertOnSubmit(model);
                mcDataCtx.SubmitChanges();
                return RedirectToAction("Create", "Register");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /User/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /User/Delete/5

        public ActionResult Delete(int id)
        {
            MedicalCasesDataClassesDataContext mcDataContext = new MedicalCasesDataClassesDataContext();
            User user = mcDataContext.Users.Single(u => u.Id == id);
            mcDataContext.Users.DeleteOnSubmit(user);
            mcDataContext.SubmitChanges();
            return RedirectToAction("Index");
        }

        //
        // POST: /User/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
