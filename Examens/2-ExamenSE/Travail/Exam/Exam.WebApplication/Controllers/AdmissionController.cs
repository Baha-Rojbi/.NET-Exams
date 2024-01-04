using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exam.WebApplication.Controllers
{
    public class AdmissionController : Controller
    {
        private IServiceAdmission sa;

        private IServicePatient sp;

        private IServiceChambre sc;
        // GET: AdmissionController
        public AdmissionController(IServiceAdmission sa, IServicePatient sp, IServiceChambre sc)
        {
            this.sa = sa;
            this.sp = sp;
            this.sc = sc;
        }

        public ActionResult Index()
        {
            return View(sa.GetAll().OrderBy(s=>s.DateAdmission));
        }

        // GET: AdmissionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdmissionController/Create
        public ActionResult Create()
        {
            ViewBag.PatientList = new SelectList(sp.GetAll().ToList(),
                "NumDossier", "CIN");
            ViewBag.ChambreList = new SelectList(sc.GetAll().ToList(),
                "NumeroChambre", "NumeroChambre");
            return View();
        }

        // POST: AdmissionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admission admission)
        {
            try
            {
                sa.Add(admission);
                sa.Commit();
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
