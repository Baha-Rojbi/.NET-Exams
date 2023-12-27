using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exam.WebApplication.Controllers
{
    public class AdmissionController : Controller
    {
        IServiceAdmission admissionService;
        IServicePatient servicePatient;
        IServiceChambre serviceChambre;
        public AdmissionController(IServiceAdmission admissionService, IServicePatient servicePatient, IServiceChambre serviceChambre)
        {
            this.admissionService = admissionService;
            this.serviceChambre = serviceChambre;
            this.servicePatient = servicePatient;

        }
        // GET: AdmissionController
        public ActionResult Index()
        {
            return View(admissionService.GetAll().OrderBy(a => a.DateAdmission));
        }

        // GET: AdmissionController/Details/5
        public ActionResult Details(string id)
        {
            return View(servicePatient.GetById(id));
        }

        // GET: AdmissionController/Create
        public ActionResult Create()
        {


            ViewBag.listePatients = new SelectList(servicePatient.GetAll(), "CIN", "CIN");
            ViewBag.listeChambres = new SelectList(serviceChambre.GetAll(), "NumeroChambre", "NumeroChambre");

            return View();
        }

        // POST: AdmissionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admission admission)
        {
            try
            {
                admissionService.Add(admission);
                admissionService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmissionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdmissionController/Edit/5
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

        // GET: AdmissionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdmissionController/Delete/5
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
