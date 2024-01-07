using Exam.CoreApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exam.WebApplication.Controllers
{
    public class EnseignantController : Controller
    {
        private IServiceUp _serviceUp;
        IServiceCandidature _serviceCandidature;
        IServiceConcours _serviceConcours;

        private IServiceEnseignant _serviceEnseignant;
        // GET: EnseignantController
        public EnseignantController(IServiceUp serviceUp, IServiceCandidature serviceCandidature, IServiceConcours serviceConcours, IServiceEnseignant serviceEnseignant)
        {
            _serviceUp = serviceUp;
            _serviceCandidature = serviceCandidature;
            _serviceConcours = serviceConcours;
            _serviceEnseignant = serviceEnseignant;
        }

        public ActionResult Index(string? code,int promotion)
        {
            ViewBag.ListUp = new SelectList(_serviceUp.GetAll().ToList(),
                "Code", "Nom");
            if (code == null&& promotion==null)
                return View(_serviceEnseignant.GetAll().ToList());
            else if(code!=null)
                return View(_serviceEnseignant.GetMany(f => f.UPFk.Equals(code)).ToList());
            else
            {
                return View(_serviceCandidature.enseignantConcours(promotion).ToList());
            }
        }

        // GET: EnseignantController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnseignantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnseignantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: EnseignantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnseignantController/Edit/5
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

        // GET: EnseignantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnseignantController/Delete/5
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
