using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exam.WebApplication.Controllers
{
    public class PrestationController : Controller
    {
        private IServicePrestataire sPrestataire;

        private IServicePrestation sPrestation;
        // GET: PrestationController
        public PrestationController(IServicePrestataire sPrestataire, IServicePrestation sPrestation)
        {
            this.sPrestataire = sPrestataire;
            this.sPrestation = sPrestation;
        }

        public ActionResult Index(int? id)
        {
            if (id==null)
            {
                return View(sPrestation.GetAll());
            }
            else
            {
                return View(sPrestation.GetMany(p=>p.PrestataireFk==id));
            }
           
        }

        // GET: PrestationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestationController/Create
        public ActionResult Create()
        {
            ViewBag.ListPrestataire= new SelectList(sPrestataire.GetAll().ToList(),
                "PrestataireId", "PrestataireNom");
            return View();
        }

        // POST: PrestationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prestation prestation)
        {
            try
            {
                sPrestation.Add(prestation);
                sPrestation.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
