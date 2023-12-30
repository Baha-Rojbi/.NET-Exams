using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.WEB.Controllers
{
    public class FeteController : Controller
    {
        IServiceFete
            serviceFete;

        public FeteController(IServiceFete serviceFete)
        {
            this.serviceFete = serviceFete;
        }

        // GET: FeteController
        public ActionResult Index(DateTime? dateDepart)
        {
          if( dateDepart == null )  
            return View(serviceFete.GetAll().OrderByDescending(p=>p.DateFete));
            return View(serviceFete.GetMany(p=>p.DateFete.Equals(dateDepart)));
        }

        // GET: FeteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FeteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FeteController/Create
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

        // GET: FeteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FeteController/Edit/5
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

        // GET: FeteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FeteController/Delete/5
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
