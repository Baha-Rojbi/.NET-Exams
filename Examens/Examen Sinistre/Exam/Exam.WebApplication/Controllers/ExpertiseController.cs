using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exam.WebApplication.Controllers
{
    public class ExpertiseController : Controller
    {
        IServiceExpertise serviceExpertise;
        IServiceSinistre serviceSinistre;
        IServiceExpert serviceExpert;

        public ExpertiseController(IServiceExpertise serviceExpertise, IServiceSinistre serviceSinistre, IServiceExpert serviceExpert)
        {
            this.serviceExpertise = serviceExpertise;
            this.serviceSinistre = serviceSinistre;
            this.serviceExpert = serviceExpert;
        }

        // GET: ExpertiseController
        public ActionResult Index(CoreApplication.Domain.TypeAssurance? typeAssurance)
        {
            if (typeAssurance == null)
                return View(serviceExpertise.GetAll().OrderBy(p => p.DateExpertise));
            return View(serviceExpertise.GetMany(p => p.Sinistre.Assurance.Type.Equals(typeAssurance)));
        }

        // GET: ExpertiseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExpertiseController/Create
        public ActionResult Create()
        {
            ViewBag.ExpertList = new SelectList(serviceExpert.GetAll(), "Id", "Id");
            ViewBag.SinistreList = new SelectList(serviceSinistre.GetAll(), "SinistreId", "SinistreId");
            return View();
        }

        // POST: ExpertiseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Expertise expertise)
        {
            try
            {
                serviceExpertise.Add(expertise);
                serviceExpertise.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExpertiseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExpertiseController/Edit/5
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

        // GET: ExpertiseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExpertiseController/Delete/5
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
