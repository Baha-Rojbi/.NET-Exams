using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exam.WebApplication.Controllers
{
    public class ClientController : Controller
    {
        private IServiceClient _serviceClient;

        private IServiceConseiller _serviceConseiller;
        // GET: ClientController
        public ClientController(IServiceClient serviceClient, IServiceConseiller serviceConseiller)
        {
            _serviceClient = serviceClient;
            _serviceConseiller = serviceConseiller;
        }

        public ActionResult Index(string? Login)
        {
            if (Login == null)
            {
                return View(_serviceClient.GetAll());
            }
            else
            {
                return View(_serviceClient.GetMany(c=>c.Login.Equals(Login)));
            }
          
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            ViewBag.ConseillerList = new SelectList(_serviceConseiller.GetAll().ToList(),
                "ConseillerId", "Nom");
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client,IFormFile Photo)
        {
            try
            {
                if (Photo!=null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads",
                        Photo.FileName);
                    Stream stream = new FileStream(path, FileMode.Create);
                    Photo.CopyTo(stream);
                    client.Photo = Photo.FileName;
                }

                _serviceClient.Add(client);
                _serviceClient.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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
