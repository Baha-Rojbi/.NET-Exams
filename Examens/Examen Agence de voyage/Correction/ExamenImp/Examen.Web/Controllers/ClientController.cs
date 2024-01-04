using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.Web.Controllers
{
    public class ClientController : Controller
    {

        IServiceClient serviceClient;
        IServiceConseiller serviceConseiller;

        public ClientController(IServiceClient serviceClient, IServiceConseiller serviceConseiller)
        {
            this.serviceClient = serviceClient;
            this.serviceConseiller = serviceConseiller;
        }

        // GET: ClientController
        public ActionResult Index()
        {
            return View(serviceClient.GetAll());
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            ViewBag.ConseillerList = new SelectList(serviceConseiller.GetAll(), "ConseillerId", "Prenom");
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client, IFormFile file)
        {
            
            if (file != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads",
               file.FileName);
                using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                client.Photo = file.FileName;
            }
            
            try
            {
                serviceClient.Add(client);
                serviceClient.Commit(); 
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
