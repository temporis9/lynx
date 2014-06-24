using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class CaseSymptomsController : Controller
    {
        //
        // GET: /CaseSymproms/

        public ActionResult Index()
        {
            /*MedicalCasesDataClassesDataContext mcDataContext = new MedicalCasesDataClassesDataContext();
            var symptomsData = from s in mcDataContext.Symptoms
                           where s.Id == id
                           select s;*/
            return View();
        }


        public ActionResult IndexAjax()
        {
            /*MedicalCasesDataClassesDataContext mcDataContext = new MedicalCasesDataClassesDataContext();
            var symptomsData = from s in mcDataContext.Symptoms
                               where s.Id == id
                               select s;*/
            return View();
        }
        //
        // GET: /CaseSymproms/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /CaseSymproms/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CaseSymproms/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /CaseSymproms/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CaseSymproms/Edit/5

        [HttpPost]
        public ActionResult Edit(int symptomId, int caseId)
        {
            try
            {
                // TODO: Add update logic here
                //return RedirectToAction("Index");
                MedicalCasesDataClassesDataContext mcDCtx = new MedicalCasesDataClassesDataContext();
                CaseSymptom model = new CaseSymptom();
                model.caseId = caseId;
                model.symptomId = symptomId;
                mcDCtx.CaseSymptoms.InsertOnSubmit(model);
                mcDCtx.SubmitChanges();
                ViewBag.error = false;
                ViewBag.message = "Symptoms stored.";
                return View();
            }
            catch
            {
                ViewBag.error = true;
                ViewBag.message = "Symptoms not added.";
                return View();
            }
        }

        //
        // GET: /CaseSymproms/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CaseSymproms/Delete/5

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
