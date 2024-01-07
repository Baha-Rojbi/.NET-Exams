using Exam.CoreApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam.WebApplication.Controllers
{
    public class CandidatureController : Controller
    {
        private IServiceCandidature _serviceCandidature;

        public CandidatureController(IServiceCandidature serviceCandidature)
        {
            _serviceCandidature = serviceCandidature;
        }

        // GET: CandidatureController
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_serviceCandidature.GetAll());
            }
            else
            {
                return View(_serviceCandidature.GetMany(c=>c.EnseignantFk==id));
            }
            
        }

        // GET: CandidatureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CandidatureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandidatureController/Create
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

        // GET: CandidatureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CandidatureController/Edit/5
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

        // GET: CandidatureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CandidatureController/Delete/5
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
