using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using WebMatrix.WebData;
using MvcApplication1.Filters;

namespace MvcApplication1.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class RegisterController : Controller
    {
       private Case model;

        //
        // GET: /Register/

        public ActionResult Index()
        {
            MedicalCasesDataClassesDataContext mcDataContext = new MedicalCasesDataClassesDataContext();
            var caseData = from c in mcDataContext.Cases
                           select c;
            return View(caseData);
        }

        //
        // GET: /Register/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Register/Create

         public ActionResult Create()
        {
            int userID = WebSecurity.CurrentUserId;
            String currentUserName = WebSecurity.CurrentUserName;
            MedicalCasesDataClassesDataContext mcDataContext = new MedicalCasesDataClassesDataContext();
            var userData = from u in mcDataContext.Users
                       where u.userName == currentUserName
                       select u;
            if (userData.Count().Equals(0)) {
                //redirect /User/create
                return RedirectToAction("Create", "User");
            }
            model = new Case();
            model.userId = userID;
            //walidator nie przpuszcza daty, chyba zły fomat, tworzenie poprzez wartość domyslną getdate()
            model.Date = DateTime.Now;
            ViewBag.userID = userID;
            return View(model);
        }

        //
        // POST: /Register/Create

        [HttpPost]
        public ActionResult Create(Case model)
        {
            try
            {
                // TODO: Add insert logic here
                MedicalCasesDataClassesDataContext mcDCtx = new MedicalCasesDataClassesDataContext();
                mcDCtx.Cases.InsertOnSubmit(model);
                mcDCtx.SubmitChanges();
                return RedirectToAction("Edit", new { id = model.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Register/Edit/5

        public ActionResult Edit(int id)
        {
            MedicalCasesDataClassesDataContext mcDataContext = new MedicalCasesDataClassesDataContext();
            Case caseModel = mcDataContext.Cases.Single(u => u.Id == id);
            return View(caseModel);
        }

        //
        // POST: /Register/Edit/5

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
        // GET: /Register/Delete/5

        public ActionResult Delete(int id)
        {
            MedicalCasesDataClassesDataContext mcDataContext = new MedicalCasesDataClassesDataContext();
            Case caseModel = mcDataContext.Cases.Single(u => u.Id == id);
            mcDataContext.Cases.DeleteOnSubmit(caseModel);
            mcDataContext.SubmitChanges();
            return RedirectToAction("Index");
        }

        //
        // POST: /Register/Delete/5

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
